using System;

namespace Messages.Core.Field.Formatters
{
	public class FormatHelpers
	{
		public static IFieldFormatter GetFormatter(FieldLength length)
		{
			switch (length)
			{
			case FieldLength.FixedLength:
				return new FixedFormatter();
			case FieldLength.LVar:
				return new LFormatter();
			case FieldLength.LLVar:
				return new LLFormatter();
			case FieldLength.LLLVar:
				return new LLLFormatter();
			case FieldLength.LLLLVar:
				return new LLLLFormatter();
			case FieldLength.LLLLLVar:
				return new LLLLLFormatter();
			case FieldLength.LLLLLLVar:
				return new LLLLLLFormatter();
			default:
				return new Empty();
			}
		}

		public static IFieldFormatter GetFormatter(string formatterName)
		{
			return (IFieldFormatter)Activator.CreateInstance(null, formatterName, new object[0]).Unwrap();
		}
	}
}
