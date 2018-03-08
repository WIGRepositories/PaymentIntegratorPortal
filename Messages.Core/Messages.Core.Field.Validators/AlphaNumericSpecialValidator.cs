using System;
using System.Collections.Generic;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class AlphaNumericSpecialValidator : Empty
	{
		public override void Validate(string content)
		{
			List<Func<char, bool>> list = new List<Func<char, bool>>();
			list.Add((char ch) => char.IsLetterOrDigit(ch));
			list.Add((char ch) => base.IsSpecial(ch));
			base.CheckChars(list, content);
		}
	}
}
