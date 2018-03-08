using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Messages.Postbridge.Helpers
{
	public class LinkedAccounts
	{
		public Dictionary<string, LinkedAccount> Accounts;

		public LinkedAccounts()
		{
			this.Accounts = new Dictionary<string, LinkedAccount>();
		}

		public LinkedAccounts(string linkedAccounts)
		{
			using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(linkedAccounts)))
			{
				this.Init(memoryStream);
			}
		}

		public LinkedAccounts(Stream stream)
		{
			this.Init(stream);
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string current in this.Accounts.Keys)
			{
				stringBuilder.Append(this.Accounts[current].ToString());
			}
			return stringBuilder.ToString();
		}

		public static LinkedAccounts FromString(string linkedAccounts)
		{
			return new LinkedAccounts(linkedAccounts);
		}

		private void Init(Stream stream)
		{
			this.Accounts = new Dictionary<string, LinkedAccount>();
			while (stream.Position < stream.Length)
			{
				LinkedAccount linkedAccount = new LinkedAccount(stream);
				this.Accounts.Add(linkedAccount.AccountID, linkedAccount);
			}
		}
	}
}
