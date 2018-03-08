using Messages.Postbridge.Enums;
using System;

namespace Messages.Postbridge.Helpers
{
	public class AccountTypeQualifiers
	{
		public AccountTypeQualifierEnum FromAccount
		{
			get;
			set;
		}

		public AccountTypeQualifierEnum ToAccount
		{
			get;
			set;
		}

		public AccountTypeQualifiers(AccountTypeQualifierEnum fromAccount, AccountTypeQualifierEnum toAccount)
		{
			this.FromAccount = fromAccount;
			this.ToAccount = toAccount;
		}

		public AccountTypeQualifiers(string fromAccount, string toAccount)
		{
			this.InitStrings(fromAccount, toAccount);
		}

		public AccountTypeQualifiers(string accountQualifiers)
		{
			this.InitStrings(accountQualifiers.Substring(0, 1), accountQualifiers.Substring(1, 1));
		}

		public override string ToString()
		{
			return EFTProperties<AccountTypeQualifierEnum>.Value(this.FromAccount).Value + EFTProperties<AccountTypeQualifierEnum>.Value(this.ToAccount).Value;
		}

		public static AccountTypeQualifiers FromString(string accountQualifiers)
		{
			return new AccountTypeQualifiers(accountQualifiers);
		}

		private void InitStrings(string fromAccount, string toAccount)
		{
			this.FromAccount = EFTProperties<AccountTypeQualifierEnum>.Enum(fromAccount);
			this.ToAccount = EFTProperties<AccountTypeQualifierEnum>.Enum(toAccount);
		}
	}
}
