using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class YYMMValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckNumericRange(content.Substring(0, 2), 0, 99);
			base.CheckNumericRange(content.Substring(2, 2), 1, 12);
		}
	}
}
