using Messages.Postbridge.Enums;
using System;

namespace Messages.Postbridge.Helpers
{
	public class AdditionalAmount
	{
		public AccountTypeEnum AccountType
		{
			get;
			set;
		}

		public AmountTypeEnum AmountType
		{
			get;
			set;
		}

		public string CurrencyCode
		{
			get;
			set;
		}

		public double Amount
		{
			get;
			set;
		}

		public AdditionalAmount(AccountTypeEnum accountType, AmountTypeEnum amountType, string currencyCode, double amount)
		{
			this.AccountType = accountType;
			this.AmountType = amountType;
			this.CurrencyCode = currencyCode;
			this.Amount = amount;
		}

		public AdditionalAmount(string accountType, string amountType, string currencyCode, double amount)
		{
			this.InitValues(accountType, amountType, currencyCode, amount);
		}

		public AdditionalAmount(string additionalAmount)
		{
			this.InitValues(additionalAmount.Substring(0, 2), additionalAmount.Substring(2, 2), additionalAmount.Substring(4, 3), Convert.ToDouble(additionalAmount.Substring(8, 12)));
			if (additionalAmount.Substring(7, 1) == "D")
			{
				this.Amount = -this.Amount;
			}
		}

		public override string ToString()
		{
			if (this.Amount < 0.0)
			{
				return string.Concat(new string[]
				{
					EFTProperties<AccountTypeEnum>.Value(this.AccountType).Value,
					EFTProperties<AmountTypeEnum>.Value(this.AmountType).Value,
					this.CurrencyCode,
					"D",
					(-this.Amount).ToString().PadLeft(12, '0')
				});
			}
			return string.Concat(new string[]
			{
				EFTProperties<AccountTypeEnum>.Value(this.AccountType).Value,
				EFTProperties<AmountTypeEnum>.Value(this.AmountType).Value,
				this.CurrencyCode,
				"C",
				this.Amount.ToString().PadLeft(12, '0')
			});
		}

		public static AdditionalAmount FromString(string additionalAmount)
		{
			return new AdditionalAmount(additionalAmount);
		}

		private void InitValues(string accountType, string amountType, string currencyCode, double amount)
		{
			this.AccountType = EFTProperties<AccountTypeEnum>.Enum(accountType);
			this.AmountType = EFTProperties<AmountTypeEnum>.Enum(amountType);
			this.CurrencyCode = currencyCode;
			this.Amount = amount;
		}
	}
}
