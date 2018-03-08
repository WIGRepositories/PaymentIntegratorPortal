using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class AccountType : EFTProperties<AccountTypeEnum>
	{
		public static EFTConstant<string> Default;

		public static EFTConstant<string> Savings;

		public static EFTConstant<string> Checkings;

		public static EFTConstant<string> Credit;

		public static EFTConstant<string> Universal;

		public static EFTConstant<string> Investment;

		public static EFTConstant<string> ElectronicPurse;

		public static EFTConstant<string> MortgageLoan;

		public static EFTConstant<string> InstallmentLoan;

		static AccountType()
		{
			AccountType.Default = new EFTConstant<string>("00");
			AccountType.Savings = new EFTConstant<string>("10");
			AccountType.Checkings = new EFTConstant<string>("20");
			AccountType.Credit = new EFTConstant<string>("30");
			AccountType.Universal = new EFTConstant<string>("40");
			AccountType.Investment = new EFTConstant<string>("50");
			AccountType.ElectronicPurse = new EFTConstant<string>("60");
			AccountType.MortgageLoan = new EFTConstant<string>("91");
			AccountType.InstallmentLoan = new EFTConstant<string>("92");
			EFTProperties<AccountTypeEnum>.Add(AccountTypeEnum.Checkings, AccountType.Checkings);
			EFTProperties<AccountTypeEnum>.Add(AccountTypeEnum.Credit, AccountType.Credit);
			EFTProperties<AccountTypeEnum>.Add(AccountTypeEnum.Default, AccountType.Default);
			EFTProperties<AccountTypeEnum>.Add(AccountTypeEnum.ElectronicPurse, AccountType.ElectronicPurse);
			EFTProperties<AccountTypeEnum>.Add(AccountTypeEnum.InstallmentLoan, AccountType.InstallmentLoan);
			EFTProperties<AccountTypeEnum>.Add(AccountTypeEnum.Investment, AccountType.Investment);
			EFTProperties<AccountTypeEnum>.Add(AccountTypeEnum.MortgageLoan, AccountType.MortgageLoan);
			EFTProperties<AccountTypeEnum>.Add(AccountTypeEnum.Savings, AccountType.Savings);
			EFTProperties<AccountTypeEnum>.Add(AccountTypeEnum.Universal, AccountType.Universal);
		}
	}
}
