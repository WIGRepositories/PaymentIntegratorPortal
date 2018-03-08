using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class AuthorizationProfile : Empty
	{
		public Messages.Postbridge.Helpers.AuthorizationProfile AuthProfile
		{
			get
			{
				return Messages.Postbridge.Helpers.AuthorizationProfile.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public AuthorizationTypeEnum AuthorizationType
		{
			get
			{
				return this.AuthProfile.AuthorizationType;
			}
			set
			{
				Messages.Postbridge.Helpers.AuthorizationProfile authProfile = this.AuthProfile;
				authProfile.AuthorizationType = value;
				this.AuthProfile = authProfile;
			}
		}

		public AuthorizationLimitsEnum AuthorizationLimits
		{
			get
			{
				return this.AuthProfile.AuthorizationLimits;
			}
			set
			{
				Messages.Postbridge.Helpers.AuthorizationProfile authProfile = this.AuthProfile;
				authProfile.AuthorizationLimits = value;
				this.AuthProfile = authProfile;
			}
		}
	}
}
