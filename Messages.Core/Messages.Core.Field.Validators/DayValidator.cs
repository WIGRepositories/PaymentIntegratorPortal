using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class DayValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckNumericRange(content, 1, 31);
		}
	}
}
