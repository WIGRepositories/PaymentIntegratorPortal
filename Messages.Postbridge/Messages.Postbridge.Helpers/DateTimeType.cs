using Messages.Core.Field;
using System;

namespace Messages.Postbridge.Helpers
{
	public class DateTimeType
	{
		private FieldFormat format;

		private DateTime m_dt;

		public DateTime DateTime
		{
			get
			{
				return this.m_dt;
			}
			set
			{
				this.m_dt = value;
			}
		}

		public string DateTimeString
		{
			get
			{
				return this.GetDateAsString();
			}
			set
			{
				this.ReadDateAsString(value);
			}
		}

		public DateTimeType(FieldFormat format, string dateTime)
		{
			this.format = format;
			this.ReadDateAsString(dateTime);
		}

		public DateTimeType(FieldFormat format, DateTime dateTime)
		{
			this.format = format;
			this.m_dt = dateTime;
		}

		public override string ToString()
		{
			return this.GetDateAsString();
		}

		private void ReadDateAsString(string text)
		{
			int year = DateTime.Now.Year;
			int month = DateTime.Now.Month;
			int day = DateTime.Now.Day;
			int hour = DateTime.Now.Hour;
			int minute = DateTime.Now.Minute;
			int second = DateTime.Now.Second;
			switch (this.format)
			{
			case FieldFormat.Year:
				year = Convert.ToInt32(text);
				break;
			case FieldFormat.CCYear:
				year = Convert.ToInt32(text);
				break;
			case FieldFormat.Month:
				month = Convert.ToInt32(text);
				break;
			case FieldFormat.Day:
				day = Convert.ToInt32(text);
				break;
			case FieldFormat.Hour:
				hour = Convert.ToInt32(text);
				break;
			case FieldFormat.Minute:
				minute = Convert.ToInt32(text);
				break;
			case FieldFormat.Second:
				second = Convert.ToInt32(text);
				break;
			case FieldFormat.MMDDhhmmss:
				month = Convert.ToInt32(text.Substring(0, 2));
				day = Convert.ToInt32(text.Substring(2, 2));
				hour = Convert.ToInt32(text.Substring(4, 2));
				minute = Convert.ToInt32(text.Substring(6, 2));
				second = Convert.ToInt32(text.Substring(8, 2));
				break;
			case FieldFormat.hhmmss:
				hour = Convert.ToInt32(text.Substring(0, 2));
				minute = Convert.ToInt32(text.Substring(2, 2));
				second = Convert.ToInt32(text.Substring(4, 2));
				break;
			case FieldFormat.MMDD:
				month = Convert.ToInt32(text.Substring(0, 2));
				day = Convert.ToInt32(text.Substring(2, 2));
				break;
			case FieldFormat.YYMM:
				year = Convert.ToInt32(text.Substring(0, 2));
				month = Convert.ToInt32(text.Substring(2, 2));
				break;
			case FieldFormat.CCYYMMDD:
				year = Convert.ToInt32(text.Substring(0, 4));
				month = Convert.ToInt32(text.Substring(4, 2));
				day = Convert.ToInt32(text.Substring(6, 2));
				break;
			case FieldFormat.YYMMDD:
				year = Convert.ToInt32(text.Substring(0, 2));
				month = Convert.ToInt32(text.Substring(2, 2));
				day = Convert.ToInt32(text.Substring(4, 2));
				break;
			default:
				return;
			}
			this.m_dt = new DateTime(year, month, day, hour, minute, second);
		}

		private string GetDateAsString()
		{
			switch (this.format)
			{
			case FieldFormat.Year:
				return this.m_dt.ToString("yy");
			case FieldFormat.CCYear:
				return this.m_dt.ToString("yyyy");
			case FieldFormat.Month:
				return this.m_dt.ToString("MM");
			case FieldFormat.Day:
				return this.m_dt.ToString("dd");
			case FieldFormat.Hour:
				return this.m_dt.ToString("HH");
			case FieldFormat.Minute:
				return this.m_dt.ToString("mm");
			case FieldFormat.Second:
				return this.m_dt.ToString("ss");
			case FieldFormat.MMDDhhmmss:
				return this.m_dt.ToString("MMddHHmmss");
			case FieldFormat.hhmmss:
				return this.m_dt.ToString("HHmmss");
			case FieldFormat.MMDD:
				return this.m_dt.ToString("MMdd");
			case FieldFormat.YYMM:
				return this.m_dt.ToString("yyMM");
			case FieldFormat.CCYYMMDD:
				return this.m_dt.ToString("yyyyMMdd");
			case FieldFormat.YYMMDD:
				return this.m_dt.ToString("yyMMdd");
			default:
				return string.Empty;
			}
		}
	}
}
