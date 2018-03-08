using System;

namespace Messages.Core.Field.Formatters
{
	[Serializable]
	public class LLFormatter : LengthFormatter
	{
		public LLFormatter()
		{
			this.length = 2;
		}
	}
}
