using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class SettlementCode : EFTProperties<SettlementCodeEnum>
	{
		public static EFTConstant<string> Unknown;

		public static EFTConstant<string> InBalance;

		public static EFTConstant<string> OutOfBalance;

		public static EFTConstant<string> Error;

		static SettlementCode()
		{
			SettlementCode.Unknown = new EFTConstant<string>("0");
			SettlementCode.InBalance = new EFTConstant<string>("1");
			SettlementCode.OutOfBalance = new EFTConstant<string>("2");
			SettlementCode.Error = new EFTConstant<string>("3");
			EFTProperties<SettlementCodeEnum>.Add(SettlementCodeEnum.Error, SettlementCode.Error);
			EFTProperties<SettlementCodeEnum>.Add(SettlementCodeEnum.InBalance, SettlementCode.InBalance);
			EFTProperties<SettlementCodeEnum>.Add(SettlementCodeEnum.OutOfBalance, SettlementCode.OutOfBalance);
			EFTProperties<SettlementCodeEnum>.Add(SettlementCodeEnum.Unknown, SettlementCode.Unknown);
		}
	}
}
