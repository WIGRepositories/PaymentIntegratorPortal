using Messages.Postbridge.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Messages.Postbridge.Helpers
{
	public class AdditionalAmounts
	{
		public List<AdditionalAmount> Amounts
		{
			get;
			set;
		}

		public AdditionalAmounts()
		{
			this.Amounts = new List<AdditionalAmount>();
		}

		public AdditionalAmounts(string additionalAmounts)
		{
			this.Amounts = new List<AdditionalAmount>();
			for (int i = 0; i < additionalAmounts.Length; i += 20)
			{
				this.Amounts.Add(new AdditionalAmount(additionalAmounts.Substring(i, 20)));
			}
		}

		public AdditionalAmounts AddAmount(AdditionalAmount amount)
		{
			this.Amounts.Add(amount);
			return this;
		}

		public AdditionalAmount GetAmount(AmountTypeEnum amountType)
		{
			foreach (AdditionalAmount current in this.Amounts)
			{
				if (current.AmountType == amountType)
				{
					return current;
				}
			}
			return null;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (AdditionalAmount current in this.Amounts)
			{
				stringBuilder.Append(current.ToString());
			}
			return stringBuilder.ToString();
		}
	}
}
