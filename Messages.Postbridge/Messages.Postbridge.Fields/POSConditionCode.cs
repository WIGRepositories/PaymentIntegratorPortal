using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class POSConditionCode : Empty
	{
		public POSConditionCodeEnum Code
		{
			get
			{
				return EFTProperties<POSConditionCodeEnum>.Enum(base.Content);
			}
			set
			{
				base.Content = EFTProperties<POSConditionCodeEnum>.Value(value).Value;
			}
		}
	}
}
