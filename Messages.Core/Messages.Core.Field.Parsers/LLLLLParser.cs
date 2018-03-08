using System;

namespace Messages.Core.Field.Parsers
{
	[Serializable]
	public class LLLLLParser : LengthParser
	{
		public LLLLLParser()
		{
			this.length = 5;
		}
	}
}
