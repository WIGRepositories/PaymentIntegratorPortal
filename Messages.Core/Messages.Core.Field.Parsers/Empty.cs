using System;
using System.IO;
using System.Text;

namespace Messages.Core.Field.Parsers
{
	[Serializable]
	public class Empty : IFieldParser
	{
		public virtual string Parse(IField field, string content)
		{
			byte[] bytes = Encoding.Default.GetBytes(content);
			string result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.Parse(field, memoryStream);
			}
			return result;
		}

		public virtual string Parse(IField field, Stream stream)
		{
			return string.Empty;
		}

		public virtual byte[] ByteParse(IField field, Stream stream)
		{
			return new byte[0];
		}

		protected string GetStringFromStream(Stream stream, int count)
		{
			return Encoding.Default.GetString(this.GetBytesFromStream(stream, count));
		}

		protected byte[] GetBytesFromStream(Stream stream, int count)
		{
			byte[] array = (byte[])Array.CreateInstance(typeof(byte), count);
			stream.Read(array, 0, count);
			return array;
		}

		protected string ParseLengthFirst(IField field, Stream stream, int lengthCount)
		{
			string stringFromStream = this.GetStringFromStream(stream, lengthCount);
			int num;
			if (int.TryParse(stringFromStream, out num) && num <= field.Size)
			{
				return this.GetStringFromStream(stream, num);
			}
			throw new InvalidCastException(string.Format("Invalid value for field [{0}]", field.Name));
		}

		protected byte[] BytesParseLengthFirst(IField field, Stream stream, int lengthCount)
		{
			string stringFromStream = this.GetStringFromStream(stream, lengthCount);
			int num;
			if (int.TryParse(stringFromStream, out num) && num <= field.Size)
			{
				return this.GetBytesFromStream(stream, num);
			}
			throw new InvalidCastException(string.Format("Invalid value for field [{0}]", field.Name));
		}
	}
}
