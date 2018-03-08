using System;
using System.IO;

namespace Messages.Core.Field.Parsers
{
	[Serializable]
	public class LengthParser : Empty
	{
		protected int length = 1;

		public override string Parse(IField field, Stream stream)
		{
			return base.ParseLengthFirst(field, stream, this.length);
		}

		public override byte[] ByteParse(IField field, Stream stream)
		{
			return base.BytesParseLengthFirst(field, stream, this.length);
		}
	}
}
