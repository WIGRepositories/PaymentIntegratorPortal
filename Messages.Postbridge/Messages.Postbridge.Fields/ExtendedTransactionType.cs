using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class ExtendedTransactionType : Empty
	{
		public ExtendedTransactionTypeEnum TranType
		{
			get
			{
				return EFTProperties<ExtendedTransactionTypeEnum>.Enum(base.Content);
			}
			set
			{
				base.Content = EFTProperties<ExtendedTransactionTypeEnum>.Value(value).Value;
			}
		}
	}
}
