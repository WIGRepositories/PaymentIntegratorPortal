using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class AccountTypeQualifier : EFTProperties<AccountTypeQualifierEnum>
	{
		public static EFTConstant<string> Unspecified;

		public static EFTConstant<string> Primary;

		public static EFTConstant<string> Secondary;

		public static EFTConstant<string> Tertiary;

		static AccountTypeQualifier()
		{
			AccountTypeQualifier.Unspecified = new EFTConstant<string>("0");
			AccountTypeQualifier.Primary = new EFTConstant<string>("1");
			AccountTypeQualifier.Secondary = new EFTConstant<string>("2");
			AccountTypeQualifier.Tertiary = new EFTConstant<string>("3");
			EFTProperties<AccountTypeQualifierEnum>.Add(AccountTypeQualifierEnum.Primary, AccountTypeQualifier.Primary);
			EFTProperties<AccountTypeQualifierEnum>.Add(AccountTypeQualifierEnum.Secondary, AccountTypeQualifier.Secondary);
			EFTProperties<AccountTypeQualifierEnum>.Add(AccountTypeQualifierEnum.Tertiary, AccountTypeQualifier.Tertiary);
			EFTProperties<AccountTypeQualifierEnum>.Add(AccountTypeQualifierEnum.Unspecified, AccountTypeQualifier.Unspecified);
		}
	}
}
