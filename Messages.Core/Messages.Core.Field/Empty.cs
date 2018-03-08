using Messages.Core.Field.Formatters;
using Messages.Core.Field.Parsers;
using Messages.Core.Field.Validators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Messages.Core.Field
{
	[Serializable]
	public class Empty : IField
	{
		private bool hasContent;

		private string m_content;

		private byte[] m_bytes;

		public string Name
		{
			get;
			set;
		}

		public int Size
		{
			get;
			set;
		}

		public int Number
		{
			get;
			set;
		}

		public FieldLength Length
		{
			get;
			set;
		}

		public FieldFormat Format
		{
			get;
			set;
		}

		public string Content
		{
			get
			{
				if (this.Format != FieldFormat.Binary)
				{
					return this.m_content;
				}
				return Encoding.Default.GetString(this.m_bytes);
			}
			set
			{
				this.m_content = value;
				this.hasContent = (value != null && value != string.Empty);
			}
		}

		public byte[] Bytes
		{
			get
			{
				return this.m_bytes;
			}
			set
			{
				this.m_bytes = value;
				this.hasContent = (this.m_bytes.Length > 0);
			}
		}

		public IFieldFormatter Formatter
		{
			get;
			set;
		}

		public IFieldValidator Validator
		{
			get;
			set;
		}

		public IFieldParser Parser
		{
			get;
			set;
		}

		public SortedList<int, IField> Subfields
		{
			get;
			set;
		}

		public IField Parent
		{
			get;
			set;
		}

		public IField Configure(string Name, int Size, int Number, FieldLength Length, FieldFormat Format, IFieldFormatter Formatter, IFieldValidator Validator, IFieldParser Parser)
		{
			this.Init(Name, Size, Number, Length, Format, Formatter, Validator, Parser);
			return this;
		}

		public IField Configure(string Name, int Size, int Number, FieldLength Length, FieldFormat Format, IFieldFormatter Formatter, IFieldParser Parser)
		{
			this.Init(Name, Size, Number, Length, Format, Formatter, ValidatorHelpers.GetValidator(Format), Parser);
			return this;
		}

		public IField Configure(string Name, int Size, int Number, FieldLength Length, FieldFormat Format)
		{
			this.Init(Name, Size, Number, Length, Format, FormatHelpers.GetFormatter(Length), ValidatorHelpers.GetValidator(Format), ParserHelpers.GetParser(Length));
			return this;
		}

		public IField AddSubfield(IField field)
		{
			field.Parent = this;
			this.Subfields.Add(field.Number, field);
			return this;
		}

		public virtual void Decode(Stream stream)
		{
			if (this.Subfields.Count == 0)
			{
				if (this.Format != FieldFormat.Binary)
				{
					this.Content = this.Parser.Parse(this, stream);
				}
				else
				{
					this.Bytes = this.Parser.ByteParse(this, stream);
				}
				this.ValidateFieldContent();
				this.AfterDecode();
				return;
			}
			this.Bytes = this.Parser.ByteParse(this, stream);
			using (MemoryStream memoryStream = new MemoryStream(this.Bytes))
			{
				List<int> list = null;
				foreach (int current in this.Subfields.Keys)
				{
					if (current == 1)
					{
						this.Subfields[current].Decode(memoryStream);
						list = ((Bitmap)this.Subfields[current]).GetDecodedBitmap();
					}
					else if (list.Contains(current))
					{
						this.Subfields[current].Decode(memoryStream);
					}
				}
			}
		}

		public virtual void Encode(Stream stream)
		{
			if (this.Subfields.Count != 0)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					foreach (int current in this.Subfields.Keys)
					{
						if (this.Subfields[current].IsSet())
						{
							this.Subfields[current].Encode(memoryStream);
						}
					}
					this.Bytes = memoryStream.ToArray();
				}
				this.Formatter.Format(this.Bytes, stream);
				return;
			}
			this.BeforeEncode();
			if (this.Format != FieldFormat.Binary)
			{
				this.Formatter.Format(this.Content, stream);
				return;
			}
			if (this.Bytes == null)
			{
				this.Bytes = (byte[])Array.CreateInstance(typeof(byte), this.Size);
			}
			this.Formatter.Format(this.Bytes, stream);
		}

		public virtual bool IsSet()
		{
			if (this.Subfields.Count == 0)
			{
				return this.hasContent;
			}
			foreach (int current in this.Subfields.Keys)
			{
				if (this.Subfields[current].IsSet())
				{
					return true;
				}
			}
			return false;
		}

		public virtual string Describe()
		{
			if (this.Subfields.Count != 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (int current in this.Subfields.Keys)
				{
					if (this.Subfields[current].IsSet())
					{
						stringBuilder.Append(this.Subfields[current].Describe() + "\r\n");
					}
				}
				return stringBuilder.ToString();
			}
			if (this.Format != FieldFormat.Binary)
			{
				return string.Format("[{0,-40}   ({1,11})]: [{2}]", this.Name, this.FormatFieldNumber(), this.Content);
			}
			return string.Format("[{0,-40}   ({1,11})]: [{2}]", this.Name, this.FormatFieldNumber(), BitConverter.ToString(this.Bytes).Replace("-", ""));
		}

		public virtual void AfterDecode()
		{
		}

		public virtual void BeforeEncode()
		{
		}

		public IField Copy()
		{
			IField field = (IField)Activator.CreateInstance(base.GetType());
			field.Name = this.Name;
			field.Size = this.Size;
			field.Number = this.Number;
			field.Length = this.Length;
			field.Format = this.Format;
			field.Validator = this.Validator;
			field.Formatter = this.Formatter;
			field.Parser = this.Parser;
			if (this.IsSet())
			{
				if (this.Format != FieldFormat.Binary)
				{
					field.Content = this.Content;
				}
				else
				{
					field.Bytes = (byte[])Array.CreateInstance(typeof(byte), this.Bytes.Length);
					this.Bytes.CopyTo(field.Bytes, 0);
				}
			}
			return field;
		}

		public string FormatFieldNumber()
		{
			if (this.Parent != null)
			{
				return ((Empty)this.Parent).FormatFieldNumber() + "." + this.Number.ToString().PadLeft(3, '0');
			}
			if (this.Number < 2)
			{
				return string.Empty;
			}
			return this.Number.ToString().PadLeft(3, '0');
		}

		protected void ValidateFieldContent()
		{
			if (this.Validator != null)
			{
				try
				{
					this.Validator.Validate(this.Content);
				}
				catch (InvalidCastException innerException)
				{
					throw new InvalidCastException(string.Format("Invalid value [{0}] for field {1}", this.Content, this.Name), innerException);
				}
				catch (Exception innerException2)
				{
					throw new InvalidCastException(string.Format("Error parsing value [{0}] for field {1}", this.Content, this.Name), innerException2);
				}
			}
		}

		protected void Init(string Name, int Size, int Number, FieldLength Length, FieldFormat Format, IFieldFormatter Formatter, IFieldValidator Validator, IFieldParser Parser)
		{
			this.Name = Name;
			this.Size = Size;
			this.Number = Number;
			this.Length = Length;
			this.Format = Format;
			this.Formatter = Formatter;
			this.Validator = Validator;
			this.Parser = Parser;
			this.Parent = null;
			this.Content = null;
			this.Subfields = new SortedList<int, IField>();
		}
	}
}
