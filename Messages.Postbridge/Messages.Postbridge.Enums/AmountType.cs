using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class AmountType : EFTProperties<AmountTypeEnum>
	{
		public static EFTConstant<string> LedgerBalance;

		public static EFTConstant<string> AvailableBalance;

		public static EFTConstant<string> RemainingThisCycle;

		public static EFTConstant<string> Cash;

		public static EFTConstant<string> Approved;

		public static EFTConstant<string> AvailableCredit;

		public static EFTConstant<string> CreditLimit;

		static AmountType()
		{
			AmountType.LedgerBalance = new EFTConstant<string>("01");
			AmountType.AvailableBalance = new EFTConstant<string>("02");
			AmountType.RemainingThisCycle = new EFTConstant<string>("20");
			AmountType.Cash = new EFTConstant<string>("40");
			AmountType.Approved = new EFTConstant<string>("53");
			AmountType.AvailableCredit = new EFTConstant<string>("90");
			AmountType.CreditLimit = new EFTConstant<string>("91");
			EFTProperties<AmountTypeEnum>.Add(AmountTypeEnum.Approved, AmountType.Approved);
			EFTProperties<AmountTypeEnum>.Add(AmountTypeEnum.AvailableBalance, AmountType.AvailableBalance);
			EFTProperties<AmountTypeEnum>.Add(AmountTypeEnum.AvailableCredit, AmountType.AvailableCredit);
			EFTProperties<AmountTypeEnum>.Add(AmountTypeEnum.Cash, AmountType.Cash);
			EFTProperties<AmountTypeEnum>.Add(AmountTypeEnum.CreditLimit, AmountType.CreditLimit);
			EFTProperties<AmountTypeEnum>.Add(AmountTypeEnum.LedgerBalance, AmountType.LedgerBalance);
			EFTProperties<AmountTypeEnum>.Add(AmountTypeEnum.RemainingThisCycle, AmountType.RemainingThisCycle);
		}
	}
}
