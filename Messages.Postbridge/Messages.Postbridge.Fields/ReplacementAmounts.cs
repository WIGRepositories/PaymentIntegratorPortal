using Messages.Core.Field;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class ReplacementAmounts : Empty
	{
		public Messages.Postbridge.Helpers.ReplacementAmounts Amounts
		{
			get
			{
				return Messages.Postbridge.Helpers.ReplacementAmounts.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public double ActualSettlementAmount
		{
			get
			{
				return this.Amounts.ActualSettlementAmount;
			}
			set
			{
				Messages.Postbridge.Helpers.ReplacementAmounts amounts = this.Amounts;
				amounts.ActualSettlementAmount = value;
				this.Amounts = amounts;
			}
		}

		public double ActualSettlementFeeAmount
		{
			get
			{
				return this.Amounts.ActualSettlementFeeAmount;
			}
			set
			{
				Messages.Postbridge.Helpers.ReplacementAmounts amounts = this.Amounts;
				amounts.ActualSettlementFeeAmount = value;
				this.Amounts = amounts;
			}
		}

		public double ActualTransactionAmount
		{
			get
			{
				return this.Amounts.ActualTransactionAmount;
			}
			set
			{
				Messages.Postbridge.Helpers.ReplacementAmounts amounts = this.Amounts;
				amounts.ActualTransactionAmount = value;
				this.Amounts = amounts;
			}
		}

		public double ActualTransactionFeeAmount
		{
			get
			{
				return this.Amounts.ActualTransactionFeeAmount;
			}
			set
			{
				Messages.Postbridge.Helpers.ReplacementAmounts amounts = this.Amounts;
				amounts.ActualTransactionFeeAmount = value;
				this.Amounts = amounts;
			}
		}
	}
}
