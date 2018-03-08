using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class AuthorizationLimits : EFTProperties<AuthorizationLimitsEnum>
	{
		public static EFTConstant<string> Unknown;

		public static EFTConstant<string> AuthorizedAgainstCardholderRecordAtCardIssuer;

		public static EFTConstant<string> AuthorizedUsingCardIssuerLimits;

		public static EFTConstant<string> AuthorizedUsingCardAcceptorLimits;

		public static EFTConstant<string> AuthorizedUsingCardIssuerBalances;

		public static EFTConstant<string> AuthorizedUsingCardIssuerVelocityLimits;

		static AuthorizationLimits()
		{
			AuthorizationLimits.Unknown = new EFTConstant<string>("0");
			AuthorizationLimits.AuthorizedAgainstCardholderRecordAtCardIssuer = new EFTConstant<string>("1");
			AuthorizationLimits.AuthorizedUsingCardIssuerLimits = new EFTConstant<string>("2");
			AuthorizationLimits.AuthorizedUsingCardAcceptorLimits = new EFTConstant<string>("3");
			AuthorizationLimits.AuthorizedUsingCardIssuerBalances = new EFTConstant<string>("4");
			AuthorizationLimits.AuthorizedUsingCardIssuerVelocityLimits = new EFTConstant<string>("5");
			EFTProperties<AuthorizationLimitsEnum>.Add(AuthorizationLimitsEnum.AuthorizedAgainstCardholderRecordAtCardIssuer, AuthorizationLimits.AuthorizedAgainstCardholderRecordAtCardIssuer);
			EFTProperties<AuthorizationLimitsEnum>.Add(AuthorizationLimitsEnum.AuthorizedUsingCardAcceptorLimits, AuthorizationLimits.AuthorizedUsingCardAcceptorLimits);
			EFTProperties<AuthorizationLimitsEnum>.Add(AuthorizationLimitsEnum.AuthorizedUsingCardIssuerBalances, AuthorizationLimits.AuthorizedUsingCardIssuerBalances);
			EFTProperties<AuthorizationLimitsEnum>.Add(AuthorizationLimitsEnum.AuthorizedUsingCardIssuerLimits, AuthorizationLimits.AuthorizedUsingCardIssuerLimits);
			EFTProperties<AuthorizationLimitsEnum>.Add(AuthorizationLimitsEnum.AuthorizedUsingCardIssuerVelocityLimits, AuthorizationLimits.AuthorizedUsingCardIssuerVelocityLimits);
			EFTProperties<AuthorizationLimitsEnum>.Add(AuthorizationLimitsEnum.Unknown, AuthorizationLimits.Unknown);
		}
	}
}
