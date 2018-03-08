using Messages.Core.Field;
using Messages.Core.Protocol;
using System;
using System.Linq;

namespace Messages.Core.Message.XML
{
	public class Default : Messages.Core.Message.Default
	{
		public Default(string XMLFileName)
		{
			base.Definition = new Definition();
			base.Definition.ReadXML(XMLFileName);
		}

		public Default(IDefinition definition)
		{
			base.Definition = definition;
		}

		public virtual Default CopyField(Default message, string fieldNumber)
		{
			IField field = message.GetField(fieldNumber);
			IField field2 = this.GetField(fieldNumber);
			if (field.IsSet())
			{
				if (field2.Format != FieldFormat.Binary)
				{
					field2.Content = field.Content;
				}
				else
				{
					field2.Bytes = (byte[])Array.CreateInstance(typeof(byte), field.Bytes.Length);
					field.Bytes.CopyTo(field2.Bytes, 0);
				}
			}
			return this;
		}

		public virtual bool IsFieldSet(string fieldNumber)
		{
			return base.IsFieldSet(this.FindField(fieldNumber).Number);
		}

		public virtual void Reset(string fieldNumber)
		{
			base.Reset(this.FindField(fieldNumber).Number);
		}

		public virtual IField GetField(string fieldNumber)
		{
			return this.FindField(fieldNumber);
		}

		public virtual IField Set(string fieldNumber)
		{
			return this.FindField(fieldNumber);
		}

		private IField FindField(string fieldNumber)
		{
			if (!fieldNumber.Contains('.'))
			{
				return base.GetField(Convert.ToInt32(fieldNumber));
			}
			string[] array = fieldNumber.Split(new char[]
			{
				'.'
			});
			IField field = base.GetField(Convert.ToInt32(array[0]));
			for (int i = 1; i <= array.GetUpperBound(0); i++)
			{
				field = field.Subfields[Convert.ToInt32(array[i])];
			}
			return field;
		}
	}
}
