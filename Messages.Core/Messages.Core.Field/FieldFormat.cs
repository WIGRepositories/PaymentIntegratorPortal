using System;

namespace Messages.Core.Field
{
	public enum FieldFormat
	{
		Alpha,
		Numeric,
		Pad,
		Special,
		AlphaNumeric,
		AlphaSpecial,
		NumericSpecial,
		None,
		AlphaNumericSpecial,
		AlphaNumericPad,
		Year,
		CCYear,
		Month,
		Day,
		Hour,
		Minute,
		Second,
		MMDDhhmmss,
		hhmmss,
		MMDD,
		YYMM,
		CCYYMMDD,
		YYMMDD,
		CreditDebit,
		CreditDebitAmount,
		Binary,
		Track2
	}
}
