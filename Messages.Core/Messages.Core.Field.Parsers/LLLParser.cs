using System;

namespace Messages.Core.Field.Parsers
{
	[Serializable]
	public class LLLParser : LengthParser
	{
		public LLLParser()
		{
			this.length = 3;
		}
	}
}
