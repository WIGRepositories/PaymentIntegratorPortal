using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class CCYYMMDDValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckChars((char ch) => char.IsDigit(ch), content);
			base.CheckMonthDay(content.Substring(4, 4));
		}
	}
}
