using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class CCYearValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckNumericRange(content, 0, 9999);
		}
	}
}
