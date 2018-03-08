using System;
using System.Collections.Generic;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class AlphaNumericPadValidator : Empty
	{
		public override void Validate(string content)
		{
			List<Func<char, bool>> list = new List<Func<char, bool>>();
			list.Add((char ch) => char.IsLetterOrDigit(ch));
			list.Add((char ch) => char.IsWhiteSpace(ch));
			base.CheckChars(list, content);
		}
	}
}
