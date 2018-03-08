using System;

namespace Messages.Core.Field.Validators
{
	public interface IFieldValidator
	{
		void Validate(string content);
	}
}
