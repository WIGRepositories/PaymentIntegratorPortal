using System;

namespace Messages.Core.Field.Parsers
{
	[Serializable]
	public class LLLLParser : LengthParser
	{
		public LLLLParser()
		{
			this.length = 4;
		}
	}
}
