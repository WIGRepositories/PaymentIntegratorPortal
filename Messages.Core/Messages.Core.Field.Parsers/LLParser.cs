using System;

namespace Messages.Core.Field.Parsers
{
	[Serializable]
	public class LLParser : LengthParser
	{
		public LLParser()
		{
			this.length = 2;
		}
	}
}
