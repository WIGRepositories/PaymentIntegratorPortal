using System;

namespace Messages.Postbridge.Helpers
{
	public class POSGeographicData
	{
		public string StateCode
		{
			get;
			set;
		}

		public string CountryCode
		{
			get;
			set;
		}

		public string PostalServiceCode
		{
			get;
			set;
		}

		public string CountryCode2
		{
			get;
			set;
		}

		public POSGeographicData(string stateCode, string countryCode, string postalServiceCode, string countryCode2)
		{
			this.InitStrings(stateCode, countryCode, postalServiceCode, countryCode2);
		}

		public POSGeographicData(string posGeoData)
		{
			this.InitStrings(posGeoData.Substring(0, 2), posGeoData.Substring(2, 3), posGeoData.Substring(5, 9), posGeoData.Substring(14, 3));
		}

		public override string ToString()
		{
			return this.StateCode + this.CountryCode + this.PostalServiceCode + this.CountryCode2;
		}

		public static POSGeographicData FromString(string posGeoData)
		{
			return new POSGeographicData(posGeoData);
		}

		private void InitStrings(string stateCode, string countryCode, string postalServiceCode, string countryCode2)
		{
			this.StateCode = stateCode;
			this.CountryCode = countryCode;
			this.PostalServiceCode = postalServiceCode;
			this.CountryCode2 = countryCode2;
		}
	}
}
