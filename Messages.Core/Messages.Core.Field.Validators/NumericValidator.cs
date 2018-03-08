using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class NumericValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckChars((char ch) => char.IsDigit(ch), content);
		}
	}
}
