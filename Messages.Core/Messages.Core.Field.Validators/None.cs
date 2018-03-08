using System;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class None : Empty
	{
		public override void Validate(string content)
		{
		}
	}
}
