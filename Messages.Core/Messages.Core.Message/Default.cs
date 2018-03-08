using Messages.Core.Field;
using Messages.Core.Protocol;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Messages.Core.Message
{
	[Serializable]
	public class Default
	{
		public IDefinition Definition
		{
			get;
			set;
		}

		static Default()
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			Assembly[] array = assemblies;
			for (int i = 0; i < array.Length; i++)
			{
				Assembly assembly = array[i];
				Type[] types = assembly.GetTypes();
				Type[] array2 = types;
				for (int j = 0; j < array2.Length; j++)
				{
					Type type = array2[j];
					object[] customAttributes = type.GetCustomAttributes(typeof(EnumsAttribute), true);
					if (customAttributes.Length > 0)
					{
						Activator.CreateInstance(type, true);
					}
				}
			}
		}

		public Default()
		{
			this.Definition = null;
		}

		public virtual void Decode(Stream stream)
		{
			FieldMap fieldMap = new FieldMap();
			foreach (int current in this.Definition.Fields.Keys)
			{
				if (current < 0)
				{
					this.Definition.Fields[current].Decode(stream);
				}
				else
				{
					if (current == 0)
					{
						Bitmap bitmap = (Bitmap)this.Definition.Fields[current];
						bitmap.Decode(stream);
						List<int> decodedBitmap = bitmap.GetDecodedBitmap();
						using (List<int>.Enumerator enumerator2 = decodedBitmap.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								int current2 = enumerator2.Current;
								fieldMap.Add(current2);
								fieldMap.Set(current2);
							}
							continue;
						}
					}
					if (current == 1 && this.Definition.Fields[current].GetType() == typeof(Bitmap))
					{
						Bitmap bitmap2 = (Bitmap)this.Definition.Fields[current];
						bitmap2.Decode(stream);
						List<int> decodedBitmap2 = bitmap2.GetDecodedBitmap();
						using (List<int>.Enumerator enumerator3 = decodedBitmap2.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								int current3 = enumerator3.Current;
								fieldMap.Add(current3);
								fieldMap.Set(current3);
							}
							continue;
						}
					}
					if (fieldMap.Bits.ContainsKey(current))
					{
						this.Definition.Fields[current].Decode(stream);
					}
				}
			}
		}

		public virtual Stream Encode()
		{
			MemoryStream memoryStream = new MemoryStream();
			foreach (int current in this.Definition.Fields.Keys)
			{
				if (this.Definition.Fields[current].IsSet())
				{
					this.Definition.Fields[current].Encode(memoryStream);
				}
			}
			return memoryStream;
		}

		public virtual IDefinition AddField(IField field)
		{
			this.Definition.Fields.Add(field.Number, field);
			return this.Definition;
		}

		public IField GetField(int fieldNumber)
		{
			return this.Definition.Fields[fieldNumber];
		}

		public virtual IField Set(int fieldNumber)
		{
			return this.Definition.Fields[fieldNumber];
		}

		public bool IsFieldSet(int fieldNumber)
		{
			return this.GetField(fieldNumber).IsSet();
		}

		public void Reset(int fieldNumber)
		{
			this.Definition.Fields[fieldNumber].Content = string.Empty;
		}

		public Default CopyField(Default message, int fieldNumber)
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

		public virtual string Describe()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (int current in this.Definition.Fields.Keys)
			{
				if (this.Definition.Fields[current].IsSet())
				{
					stringBuilder.Append(this.Definition.Fields[current].Describe());
					stringBuilder.Append("\r\n");
				}
			}
			return stringBuilder.ToString();
		}
	}
}
