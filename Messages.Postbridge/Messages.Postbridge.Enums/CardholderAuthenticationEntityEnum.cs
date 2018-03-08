using System;

namespace Messages.Postbridge.Enums
{
	public enum CardholderAuthenticationEntityEnum
	{
		NotAuthenticated,
		ICC,
		Terminal,
		AuthorizingAgent,
		Merchant,
		Other
	}
}
