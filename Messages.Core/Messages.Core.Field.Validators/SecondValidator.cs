using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class SecondValidator : Empty
	{
		public override void Validate(string content)
		{
			base.CheckNumericRange(content, 0, 59);
		}
	}
}
