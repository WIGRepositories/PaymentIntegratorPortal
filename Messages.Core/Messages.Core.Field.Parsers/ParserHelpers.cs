using System;

namespace Messages.Core.Field.Parsers
{
	public class ParserHelpers
	{
		public static IFieldParser GetParser(FieldLength length)
		{
			switch (length)
			{
			case FieldLength.FixedLength:
				return new FixedParser();
			case FieldLength.LVar:
				return new LParser();
			case FieldLength.LLVar:
				return new LLParser();
			case FieldLength.LLLVar:
				return new LLLParser();
			case FieldLength.LLLLVar:
				return new LLLLParser();
			case FieldLength.LLLLLVar:
				return new LLLLLParser();
			case FieldLength.LLLLLLVar:
				return new LLLLLLParser();
			default:
				return new Empty();
			}
		}

		public static IFieldParser GetParser(string parserName)
		{
			return (IFieldParser)Activator.CreateInstance(null, parserName, new object[0]).Unwrap();
		}
	}
}
