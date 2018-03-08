using System;
using System.IO;
using System.Text;

namespace Messages.Core.Field.Formatters
{
	[Serializable]
	public class BCDFormatter : Empty
	{
		public override string Format(byte[] content)
		{
			return BitConverter.ToString(content).Replace("-", "");
		}

		public override void Format(byte[] content, Stream stream)
		{
			string s = BitConverter.ToString(content).Replace("-", "");
			byte[] bytes = Encoding.Default.GetBytes(s);
			stream.Write(bytes, 0, bytes.GetLength(0));
		}
	}
}
