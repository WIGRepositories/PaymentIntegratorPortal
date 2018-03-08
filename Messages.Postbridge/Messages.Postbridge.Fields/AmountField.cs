using Messages.Core.Field;
using System;

namespace Messages.Postbridge.Fields
{
	public class AmountField : Empty
	{
		public double Amount
		{
			get
			{
				if (base.Format != FieldFormat.CreditDebitAmount)
				{
					return Convert.ToDouble(base.Content);
				}
				if (base.Content.StartsWith("D"))
				{
					return -Convert.ToDouble(base.Content.Substring(1));
				}
				return Convert.ToDouble(base.Content.Substring(1));
			}
			set
			{
				if (base.Format != FieldFormat.CreditDebitAmount)
				{
					base.Content = value.ToString().PadLeft(base.Size, '0');
					return;
				}
				if (value < 0.0)
				{
					base.Content = "D" + (-value).ToString().PadLeft(base.Size - 1, '0');
					return;
				}
				base.Content = "C" + value.ToString().PadLeft(base.Size - 1, '0');
			}
		}
	}
}
