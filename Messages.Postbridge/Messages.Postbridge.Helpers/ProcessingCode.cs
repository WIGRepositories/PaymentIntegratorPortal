using Messages.Postbridge.Enums;
using System;

namespace Messages.Postbridge.Helpers
{
	public class ProcessingCode
	{
		public TransactionTypeEnum TransactionType
		{
			get;
			set;
		}

		public AccountTypeEnum FromAccount
		{
			get;
			set;
		}

		public AccountTypeEnum ToAccount
		{
			get;
			set;
		}

		public ProcessingCode(TransactionTypeEnum tranType, AccountTypeEnum fromAccount, AccountTypeEnum toAccount)
		{
			this.TransactionType = tranType;
			this.FromAccount = fromAccount;
			this.ToAccount = toAccount;
		}

		public ProcessingCode(string tranType, string fromAccount, string toAccount)
		{
			this.InitStrings(tranType, fromAccount, toAccount);
		}

		public ProcessingCode(string processingCode)
		{
			this.InitStrings(processingCode.Substring(0, 2), processingCode.Substring(2, 2), processingCode.Substring(4, 2));
		}

		public override string ToString()
		{
			return EFTProperties<TransactionTypeEnum>.Value(this.TransactionType).Value + EFTProperties<AccountTypeEnum>.Value(this.FromAccount).Value + EFTProperties<AccountTypeEnum>.Value(this.ToAccount).Value;
		}

		public static ProcessingCode FromString(string processingCode)
		{
			return new ProcessingCode(processingCode);
		}

		private void InitStrings(string tranType, string fromAccount, string toAccount)
		{
			this.TransactionType = EFTProperties<TransactionTypeEnum>.Enum(tranType);
			this.FromAccount = EFTProperties<AccountTypeEnum>.Enum(fromAccount);
			this.ToAccount = EFTProperties<AccountTypeEnum>.Enum(toAccount);
		}
	}
}
