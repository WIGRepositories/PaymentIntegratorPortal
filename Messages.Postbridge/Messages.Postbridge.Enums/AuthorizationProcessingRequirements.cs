using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class AuthorizationProcessingRequirements : EFTProperties<AuthorizationProcessingRequirementsEnum>
	{
		public static EFTConstant<string> NormalAuthorization;

		public static EFTConstant<string> OnlineAuthorizationMandatory;

		public static EFTConstant<string> OnlineAuthorizationMandatory2;

		static AuthorizationProcessingRequirements()
		{
			AuthorizationProcessingRequirements.NormalAuthorization = new EFTConstant<string>("0");
			AuthorizationProcessingRequirements.OnlineAuthorizationMandatory = new EFTConstant<string>("2");
			AuthorizationProcessingRequirements.OnlineAuthorizationMandatory2 = new EFTConstant<string>("4");
			EFTProperties<AuthorizationProcessingRequirementsEnum>.Add(AuthorizationProcessingRequirementsEnum.NormalAuthorization, AuthorizationProcessingRequirements.NormalAuthorization);
			EFTProperties<AuthorizationProcessingRequirementsEnum>.Add(AuthorizationProcessingRequirementsEnum.OnlineAuthorizationMandatory, AuthorizationProcessingRequirements.OnlineAuthorizationMandatory);
			EFTProperties<AuthorizationProcessingRequirementsEnum>.Add(AuthorizationProcessingRequirementsEnum.OnlineAuthorizationMandatory2, AuthorizationProcessingRequirements.OnlineAuthorizationMandatory2);
		}
	}
}
