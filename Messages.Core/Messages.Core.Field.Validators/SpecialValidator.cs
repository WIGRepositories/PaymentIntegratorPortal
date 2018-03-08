using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class SpecialValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckChars((char ch) => base.IsSpecial(ch), content);
		}
	}
}
