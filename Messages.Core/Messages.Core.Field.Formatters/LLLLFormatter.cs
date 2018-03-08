using System;

namespace Messages.Core.Field.Formatters
{
	[Serializable]
	public class LLLLFormatter : LengthFormatter
	{
		public LLLLFormatter()
		{
			this.length = 4;
		}
	}
}
