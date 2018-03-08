using System;

namespace Messages.Postbridge.Helpers
{
	public class EFTConstant<T>
	{
		public T Value
		{
			get;
			set;
		}

		public EFTConstant()
		{
		}

		public EFTConstant(T value)
		{
			this.Value = value;
		}
	}
}
