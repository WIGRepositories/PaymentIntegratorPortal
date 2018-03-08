using Messages.Core.Field;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class CardAcceptorNameLocation : Empty
	{
		public Messages.Postbridge.Helpers.CardAcceptorNameLocation NameLocation
		{
			get
			{
				return Messages.Postbridge.Helpers.CardAcceptorNameLocation.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public string City
		{
			get
			{
				return this.NameLocation.City;
			}
			set
			{
				Messages.Postbridge.Helpers.CardAcceptorNameLocation nameLocation = this.NameLocation;
				nameLocation.City = value;
				this.NameLocation = nameLocation;
			}
		}

		public string Country
		{
			get
			{
				return this.NameLocation.Country;
			}
			set
			{
				Messages.Postbridge.Helpers.CardAcceptorNameLocation nameLocation = this.NameLocation;
				nameLocation.Country = value;
				this.NameLocation = nameLocation;
			}
		}

		public string LocationInformation
		{
			get
			{
				return this.NameLocation.LocationInformation;
			}
			set
			{
				Messages.Postbridge.Helpers.CardAcceptorNameLocation nameLocation = this.NameLocation;
				nameLocation.LocationInformation = value;
				this.NameLocation = nameLocation;
			}
		}

		public string State
		{
			get
			{
				return this.NameLocation.State;
			}
			set
			{
				Messages.Postbridge.Helpers.CardAcceptorNameLocation nameLocation = this.NameLocation;
				nameLocation.State = value;
				this.NameLocation = nameLocation;
			}
		}
	}
}
