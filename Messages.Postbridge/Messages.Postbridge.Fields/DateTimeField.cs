using Messages.Core.Field;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class DateTimeField : Empty
	{
		public DateTime DateTime
		{
			get
			{
				return new DateTimeType(base.Format, base.Content).DateTime;
			}
			set
			{
				base.Content = new DateTimeType(base.Format, value).DateTimeString;
			}
		}
	}
}
