using System;
using System.IO;
using System.Text;

namespace Messages.Core.Field.Formatters
{
	[Serializable]
	public class Empty : IFieldFormatter
	{
		public virtual string Format(string content)
		{
			return content;
		}

		public virtual void Format(string content, Stream stream)
		{
			byte[] bytes = Encoding.Default.GetBytes(content);
			stream.Write(bytes, 0, bytes.GetLength(0));
		}

		public virtual string Format(byte[] content)
		{
			return Encoding.Default.GetString(content);
		}

		public virtual void Format(byte[] content, Stream stream)
		{
			stream.Write(content, 0, content.GetLength(0));
		}

		protected string GetLength(int len, int lenLength)
		{
			return len.ToString().PadLeft(lenLength, '0');
		}

		protected byte[] ByteGetLength(int len, int lenLength)
		{
			return Encoding.Default.GetBytes(this.GetLength(len, lenLength));
		}
	}
}
