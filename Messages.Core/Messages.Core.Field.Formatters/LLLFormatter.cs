using System;

namespace Messages.Core.Field.Formatters
{
	[Serializable]
	public class LLLFormatter : LengthFormatter
	{
		public LLLFormatter()
		{
			this.length = 3;
		}
	}
}
