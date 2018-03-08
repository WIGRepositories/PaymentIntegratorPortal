using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class CreditDebitAmountValidator : Empty
	{
		public override void Validate(string content)
		{
			if (content.Substring(0, 1) != "D" && content.Substring(0, 1) != "C")
			{
				throw new InvalidCastException(string.Format("Invalid value [{0}]", content));
			}
			base.CheckChars((char ch) => char.IsDigit(ch), content.Substring(1));
		}
	}
}
