using System;

namespace Messages.Postbridge.Helpers
{
	public class CardAcceptorNameLocation
	{
		public string LocationInformation
		{
			get;
			set;
		}

		public string City
		{
			get;
			set;
		}

		public string State
		{
			get;
			set;
		}

		public string Country
		{
			get;
			set;
		}

		public CardAcceptorNameLocation(string locationInfo, string city, string state, string country)
		{
			this.LocationInformation = locationInfo;
			this.City = city;
			this.State = state;
			this.Country = country;
		}

		public CardAcceptorNameLocation(string nameLocation)
		{
			this.LocationInformation = nameLocation.Substring(0, 23);
			this.City = nameLocation.Substring(23, 13);
			this.State = nameLocation.Substring(36, 2);
			this.Country = nameLocation.Substring(38, 2);
		}

		public override string ToString()
		{
			return this.LocationInformation.PadLeft(22) + this.City.PadLeft(13) + this.State.PadLeft(2) + this.Country.PadLeft(2);
		}

		public static CardAcceptorNameLocation FromString(string nameLocation)
		{
			return new CardAcceptorNameLocation(nameLocation);
		}
	}
}
