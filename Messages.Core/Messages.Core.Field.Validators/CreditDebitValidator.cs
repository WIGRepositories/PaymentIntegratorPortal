using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class CreditDebitValidator : Empty
	{
		public override void Validate(string content)
		{
			if (content != "D" && content != "C")
			{
				throw new InvalidCastException(string.Format("Invalid value [{0}]", content));
			}
		}
	}
}
