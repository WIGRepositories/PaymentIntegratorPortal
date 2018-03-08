using System;

namespace Messages.Core.Field.Formatters
{
	[Serializable]
	public class LLLLLFormatter : LengthFormatter
	{
		public LLLLLFormatter()
		{
			this.length = 5;
		}
	}
}
