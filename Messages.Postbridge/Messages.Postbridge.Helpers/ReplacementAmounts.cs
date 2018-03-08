using System;

namespace Messages.Postbridge.Helpers
{
	public class ReplacementAmounts
	{
		public double ActualTransactionAmount
		{
			get;
			set;
		}

		public double ActualSettlementAmount
		{
			get;
			set;
		}

		public double ActualTransactionFeeAmount
		{
			get;
			set;
		}

		public double ActualSettlementFeeAmount
		{
			get;
			set;
		}

		public ReplacementAmounts(double actualTransactionAmount, double actualSettlementAmount, double actualTransactionFeeAmount, double actualSettlementFeeAmount)
		{
			this.ActualTransactionAmount = actualTransactionAmount;
			this.ActualSettlementAmount = actualSettlementAmount;
			this.ActualTransactionFeeAmount = actualTransactionFeeAmount;
			this.ActualSettlementFeeAmount = actualSettlementFeeAmount;
		}

		public ReplacementAmounts(string replacementAmounts)
		{
			this.ActualTransactionAmount = Convert.ToDouble(replacementAmounts.Substring(0, 12));
			this.ActualSettlementAmount = Convert.ToDouble(replacementAmounts.Substring(12, 12));
			this.ActualTransactionFeeAmount = Convert.ToDouble(replacementAmounts.Substring(25, 8));
			if (replacementAmounts.Substring(24, 1) == "D")
			{
				this.ActualTransactionFeeAmount = -this.ActualTransactionFeeAmount;
			}
			this.ActualSettlementFeeAmount = Convert.ToDouble(replacementAmounts.Substring(34, 8));
			if (replacementAmounts.Substring(33, 1) == "D")
			{
				this.ActualSettlementFeeAmount = -this.ActualSettlementFeeAmount;
			}
		}

		public override string ToString()
		{
			return this.ActualTransactionAmount.ToString().PadLeft(12, '0') + this.ActualSettlementAmount.ToString().PadLeft(12, '0') + this.GetSignedAmount(this.ActualTransactionFeeAmount) + this.GetSignedAmount(this.ActualSettlementFeeAmount);
		}

		public static ReplacementAmounts FromString(string replacementAmounts)
		{
			return new ReplacementAmounts(replacementAmounts);
		}

		private string GetSignedAmount(double val)
		{
			if (val < 0.0)
			{
				return "D" + (-val).ToString().PadLeft(8, '0');
			}
			return "C" + val.ToString().PadLeft(8, '0');
		}
	}
}
