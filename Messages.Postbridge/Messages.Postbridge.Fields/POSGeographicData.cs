using Messages.Core.Field;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class POSGeographicData : Empty
	{
		public Messages.Postbridge.Helpers.POSGeographicData GeographicData
		{
			get
			{
				return Messages.Postbridge.Helpers.POSGeographicData.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public string StateCode
		{
			get
			{
				return this.GeographicData.StateCode;
			}
			set
			{
				Messages.Postbridge.Helpers.POSGeographicData geographicData = this.GeographicData;
				geographicData.StateCode = value;
				this.GeographicData = geographicData;
			}
		}

		public string CountryCode
		{
			get
			{
				return this.GeographicData.CountryCode;
			}
			set
			{
				Messages.Postbridge.Helpers.POSGeographicData geographicData = this.GeographicData;
				geographicData.CountryCode = value;
				this.GeographicData = geographicData;
			}
		}

		public string PostalServiceCode
		{
			get
			{
				return this.GeographicData.PostalServiceCode;
			}
			set
			{
				Messages.Postbridge.Helpers.POSGeographicData geographicData = this.GeographicData;
				geographicData.PostalServiceCode = value;
				this.GeographicData = geographicData;
			}
		}

		public string CountryCode2
		{
			get
			{
				return this.GeographicData.CountryCode2;
			}
			set
			{
				Messages.Postbridge.Helpers.POSGeographicData geographicData = this.GeographicData;
				geographicData.CountryCode2 = value;
				this.GeographicData = geographicData;
			}
		}
	}
}
