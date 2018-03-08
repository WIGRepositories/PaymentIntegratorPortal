using System;

namespace Messages.Postbridge.Enums
{
	public enum AuthorizationTypeEnum
	{
		Unknown,
		AuthorizedByCardIssuer,
		OnlineStandin,
		TimeoutStandin,
		OfflineStandin,
		Deprecated,
		AuthorizedByVisa,
		DeclinedBySinkNodeNotSentToRemoteEntity,
		DeclinedBySinkNodeApprovedMessageReceivedFromRemoteEntity
	}
}
