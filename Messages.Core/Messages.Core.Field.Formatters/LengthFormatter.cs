using System;
using System.IO;
using System.Text;

namespace Messages.Core.Field.Formatters
{
	[Serializable]
	public class LengthFormatter : Empty
	{
		protected int length = 1;

		public override string Format(string content)
		{
			return base.GetLength(content.Length, this.length) + content;
		}

		public override void Format(string content, Stream stream)
		{
			base.Format(base.GetLength(content.Length, this.length), stream);
			base.Format(content, stream);
		}

		public override string Format(byte[] content)
		{
			return base.GetLength(content.GetLength(0), this.length) + Encoding.Default.GetString(content);
		}

		public override void Format(byte[] content, Stream stream)
		{
			base.Format(base.GetLength(content.Length, this.length), stream);
			base.Format(content, stream);
		}
	}
}
