using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class YYMMDDValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckChars((char ch) => char.IsDigit(ch), content);
			base.CheckMonthDay(content.Substring(2, 4));
		}
	}
}
