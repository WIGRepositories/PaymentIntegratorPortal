using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class AlphaNumericValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckChars((char ch) => char.IsLetterOrDigit(ch), content);
		}
	}
}
