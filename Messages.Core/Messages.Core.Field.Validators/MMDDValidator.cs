using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class MMDDValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckChars((char ch) => char.IsDigit(ch), content);
			base.CheckMonthDay(content);
		}
	}
}
