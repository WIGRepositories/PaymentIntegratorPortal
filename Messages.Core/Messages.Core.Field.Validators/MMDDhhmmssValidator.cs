using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class MMDDhhmmssValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckChars((char ch) => char.IsDigit(ch), content);
			base.CheckMonthDay(content.Substring(0, 4));
			base.CheckHour(content.Substring(4, 6));
		}
	}
}
