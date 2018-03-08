using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class PadValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckChars((char ch) => char.IsWhiteSpace(ch), content);
		}
	}
}
