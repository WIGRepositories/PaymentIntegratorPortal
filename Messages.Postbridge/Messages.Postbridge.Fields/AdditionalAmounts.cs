using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class AdditionalAmounts : Empty
	{
		public Messages.Postbridge.Helpers.AdditionalAmounts Amounts
		{
			get
			{
				return new Messages.Postbridge.Helpers.AdditionalAmounts(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public AdditionalAmount GetAmount(AmountTypeEnum amountType)
		{
			return this.Amounts.GetAmount(amountType);
		}

		public void AddAmount(AdditionalAmount amount)
		{
			Messages.Postbridge.Helpers.AdditionalAmounts amounts = this.Amounts;
			amounts.AddAmount(amount);
			this.Amounts = amounts;
		}
	}
}
