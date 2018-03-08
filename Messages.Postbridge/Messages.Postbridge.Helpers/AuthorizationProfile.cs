using Messages.Postbridge.Enums;
using System;

namespace Messages.Postbridge.Helpers
{
	public class AuthorizationProfile
	{
		public AuthorizationTypeEnum AuthorizationType
		{
			get;
			set;
		}

		public AuthorizationLimitsEnum AuthorizationLimits
		{
			get;
			set;
		}

		public AuthorizationProfile(AuthorizationTypeEnum authorizationType, AuthorizationLimitsEnum authorizationLimits)
		{
			this.AuthorizationLimits = authorizationLimits;
			this.AuthorizationType = authorizationType;
		}

		public AuthorizationProfile(string authorizationType, string authorizationLimits)
		{
			this.InitStrings(authorizationType, authorizationLimits);
		}

		public AuthorizationProfile(string authProfile)
		{
			this.InitStrings(authProfile.Substring(0, 1), authProfile.Substring(1, 1));
		}

		public override string ToString()
		{
			return EFTProperties<AuthorizationTypeEnum>.Value(this.AuthorizationType).Value + EFTProperties<AuthorizationLimitsEnum>.Value(this.AuthorizationLimits).Value;
		}

		public static AuthorizationProfile FromString(string authProfile)
		{
			return new AuthorizationProfile(authProfile);
		}

		private void InitStrings(string authorizationType, string authorizationLimits)
		{
			this.AuthorizationType = EFTProperties<AuthorizationTypeEnum>.Enum(authorizationType);
			this.AuthorizationLimits = EFTProperties<AuthorizationLimitsEnum>.Enum(authorizationLimits);
		}
	}
}
