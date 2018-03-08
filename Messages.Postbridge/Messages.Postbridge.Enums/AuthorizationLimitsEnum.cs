using System;

namespace Messages.Postbridge.Enums
{
	public enum AuthorizationLimitsEnum
	{
		Unknown,
		AuthorizedAgainstCardholderRecordAtCardIssuer,
		AuthorizedUsingCardIssuerLimits,
		AuthorizedUsingCardAcceptorLimits,
		AuthorizedUsingCardIssuerBalances,
		AuthorizedUsingCardIssuerVelocityLimits
	}
}
