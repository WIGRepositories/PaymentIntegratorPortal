using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class AuthorizationType : EFTProperties<AuthorizationTypeEnum>
	{
		public static EFTConstant<string> Unknown;

		public static EFTConstant<string> AuthorizedByCardIssuer;

		public static EFTConstant<string> OnlineStandin;

		public static EFTConstant<string> TimeoutStandin;

		public static EFTConstant<string> OfflineStandin;

		public static EFTConstant<string> Deprecated;

		public static EFTConstant<string> AuthorizedByVisa;

		public static EFTConstant<string> DeclinedBySinkNodeNotSentToRemoteEntity;

		public static EFTConstant<string> DeclinedBySinkNodeApprovedMessageReceivedFromRemoteEntity;

		static AuthorizationType()
		{
			AuthorizationType.Unknown = new EFTConstant<string>("0");
			AuthorizationType.AuthorizedByCardIssuer = new EFTConstant<string>("1");
			AuthorizationType.OnlineStandin = new EFTConstant<string>("2");
			AuthorizationType.TimeoutStandin = new EFTConstant<string>("3");
			AuthorizationType.OfflineStandin = new EFTConstant<string>("4");
			AuthorizationType.Deprecated = new EFTConstant<string>("5");
			AuthorizationType.AuthorizedByVisa = new EFTConstant<string>("9");
			AuthorizationType.DeclinedBySinkNodeNotSentToRemoteEntity = new EFTConstant<string>("A");
			AuthorizationType.DeclinedBySinkNodeApprovedMessageReceivedFromRemoteEntity = new EFTConstant<string>("B");
			EFTProperties<AuthorizationTypeEnum>.Add(AuthorizationTypeEnum.AuthorizedByCardIssuer, AuthorizationType.AuthorizedByCardIssuer);
			EFTProperties<AuthorizationTypeEnum>.Add(AuthorizationTypeEnum.AuthorizedByVisa, AuthorizationType.AuthorizedByVisa);
			EFTProperties<AuthorizationTypeEnum>.Add(AuthorizationTypeEnum.DeclinedBySinkNodeApprovedMessageReceivedFromRemoteEntity, AuthorizationType.DeclinedBySinkNodeApprovedMessageReceivedFromRemoteEntity);
			EFTProperties<AuthorizationTypeEnum>.Add(AuthorizationTypeEnum.DeclinedBySinkNodeNotSentToRemoteEntity, AuthorizationType.DeclinedBySinkNodeNotSentToRemoteEntity);
			EFTProperties<AuthorizationTypeEnum>.Add(AuthorizationTypeEnum.Deprecated, AuthorizationType.Deprecated);
			EFTProperties<AuthorizationTypeEnum>.Add(AuthorizationTypeEnum.OfflineStandin, AuthorizationType.OfflineStandin);
			EFTProperties<AuthorizationTypeEnum>.Add(AuthorizationTypeEnum.OnlineStandin, AuthorizationType.OnlineStandin);
			EFTProperties<AuthorizationTypeEnum>.Add(AuthorizationTypeEnum.TimeoutStandin, AuthorizationType.TimeoutStandin);
			EFTProperties<AuthorizationTypeEnum>.Add(AuthorizationTypeEnum.Unknown, AuthorizationType.Unknown);
		}
	}
}
