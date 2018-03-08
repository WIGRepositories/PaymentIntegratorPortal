using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class MonthValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckNumericRange(content, 1, 12);
		}
	}
}
