using System;

namespace Messages.Core.Field.Validators
{
	public class ValidatorHelpers
	{
		public static IFieldValidator GetValidator(FieldFormat format)
		{
			switch (format)
			{
			case FieldFormat.Alpha:
				return new AlphaValidator();
			case FieldFormat.Numeric:
				return new NumericValidator();
			case FieldFormat.Pad:
				return new PadValidator();
			case FieldFormat.Special:
				return new SpecialValidator();
			case FieldFormat.AlphaNumeric:
				return new AlphaNumericValidator();
			case FieldFormat.AlphaSpecial:
				return new AlphaSpecialValidator();
			case FieldFormat.NumericSpecial:
				return new NumericSpecialValidator();
			case FieldFormat.None:
				return new None();
			case FieldFormat.AlphaNumericSpecial:
				return new AlphaNumericSpecialValidator();
			case FieldFormat.AlphaNumericPad:
				return new AlphaNumericPadValidator();
			case FieldFormat.Year:
				return new YearValidator();
			case FieldFormat.CCYear:
				return new CCYearValidator();
			case FieldFormat.Month:
				return new MonthValidator();
			case FieldFormat.Day:
				return new DayValidator();
			case FieldFormat.Hour:
				return new HourValidator();
			case FieldFormat.Minute:
				return new MinuteValidator();
			case FieldFormat.Second:
				return new SecondValidator();
			case FieldFormat.MMDDhhmmss:
				return new MMDDhhmmssValidator();
			case FieldFormat.hhmmss:
				return new hhmmssValidator();
			case FieldFormat.MMDD:
				return new MMDDValidator();
			case FieldFormat.YYMM:
				return new YYMMValidator();
			case FieldFormat.CCYYMMDD:
				return new CCYYMMDDValidator();
			case FieldFormat.YYMMDD:
				return new YYMMDDValidator();
			case FieldFormat.CreditDebit:
				return new CreditDebitValidator();
			case FieldFormat.CreditDebitAmount:
				return new CreditDebitAmountValidator();
			default:
				return new Empty();
			}
		}

		public static IFieldValidator GetValidator(string validatorName)
		{
			return (IFieldValidator)Activator.CreateInstance(null, validatorName, new object[0]).Unwrap();
		}
	}
}
