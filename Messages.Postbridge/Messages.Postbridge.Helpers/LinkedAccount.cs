using System;
using System.IO;
using System.Text;

namespace Messages.Postbridge.Helpers
{
	public class LinkedAccount
	{
		public string AccountID
		{
			get;
			set;
		}

		public string AccountType
		{
			get;
			set;
		}

		public string CurrencyCode
		{
			get;
			set;
		}

		public double LedgerBalance
		{
			get;
			set;
		}

		public LinkedAccount(string accountID, string accountType, string currencyCode, double ledgerBalance)
		{
			this.AccountID = accountID;
			this.AccountType = accountType;
			this.CurrencyCode = currencyCode;
			this.LedgerBalance = ledgerBalance;
		}

		public LinkedAccount(string linkedAccount)
		{
			this.InitFromString(linkedAccount);
		}

		public LinkedAccount(Stream stream)
		{
			this.InitFromString(this.ReadStringFromStream(stream, 46));
		}

		public override string ToString()
		{
			if (this.LedgerBalance > 0.0)
			{
				return string.Concat(new string[]
				{
					this.AccountID,
					this.AccountType,
					this.CurrencyCode,
					"C",
					this.LedgerBalance.ToString().PadLeft(12, '0')
				});
			}
			return string.Concat(new string[]
			{
				this.AccountID,
				this.AccountType,
				this.CurrencyCode,
				"D",
				(-this.LedgerBalance).ToString().PadLeft(12, '0')
			});
		}

		public static LinkedAccount FromString(string linkedAccount)
		{
			return new LinkedAccount(linkedAccount);
		}

		private void InitFromString(string linkedAccount)
		{
			this.AccountID = linkedAccount.Substring(0, 28);
			this.AccountType = linkedAccount.Substring(28, 2);
			this.CurrencyCode = linkedAccount.Substring(30, 3);
			string a = linkedAccount.Substring(33, 1);
			this.LedgerBalance = Convert.ToDouble(linkedAccount.Substring(34, 12));
			if (a == "D")
			{
				this.LedgerBalance = -this.LedgerBalance;
			}
		}

		private string ReadStringFromStream(Stream stream, int len)
		{
			byte[] array = (byte[])Array.CreateInstance(typeof(byte), len);
			stream.Read(array, 0, len);
			return Encoding.ASCII.GetString(array);
		}
	}
}
