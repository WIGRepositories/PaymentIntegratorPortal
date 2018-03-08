using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class AlphaValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckChars((char ch) => char.IsLetter(ch), content);
		}
	}
}
