using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class SettlementCode : Empty
	{
		public SettlementCodeEnum Code
		{
			get
			{
				return EFTProperties<SettlementCodeEnum>.Enum(base.Content);
			}
			set
			{
				base.Content = EFTProperties<SettlementCodeEnum>.Value(value).Value;
			}
		}
	}
}
