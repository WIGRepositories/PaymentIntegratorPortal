using System;
using System.IO;

namespace Messages.Core.Field.Parsers
{
	[Serializable]
	public class FixedParser : Empty
	{
		public override string Parse(IField field, Stream stream)
		{
			return base.GetStringFromStream(stream, field.Size);
		}

		public override byte[] ByteParse(IField field, Stream stream)
		{
			return base.GetBytesFromStream(stream, field.Size);
		}
	}
}
