using Messages.Postbridge.Enums;
using System;

namespace Messages.Postbridge.Helpers
{
	public class ServiceRestrictionCode
	{
		public AreaOfUsageEnum AreaOfUsage
		{
			get;
			set;
		}

		public AuthorizationProcessingRequirementsEnum AuthorizationProcessingRequirements
		{
			get;
			set;
		}

		public ServicesAndPINRequirementsEnum ServicesAndPINRequirements
		{
			get;
			set;
		}

		public ServiceRestrictionCode(AreaOfUsageEnum areaOfUsage, AuthorizationProcessingRequirementsEnum authProcessingRequirements, ServicesAndPINRequirementsEnum servicesAndPINRequirements)
		{
			this.AreaOfUsage = areaOfUsage;
			this.AuthorizationProcessingRequirements = authProcessingRequirements;
			this.ServicesAndPINRequirements = servicesAndPINRequirements;
		}

		public ServiceRestrictionCode(string areaOfUsage, string authProcessingRequirements, string servicesAndPINRequirements)
		{
			this.InitStrings(areaOfUsage, authProcessingRequirements, servicesAndPINRequirements);
		}

		public ServiceRestrictionCode(string serviceRestrictionCode)
		{
			this.InitStrings(serviceRestrictionCode.Substring(0, 1), serviceRestrictionCode.Substring(1, 1), serviceRestrictionCode.Substring(2, 1));
		}

		public override string ToString()
		{
			return EFTProperties<AreaOfUsageEnum>.Value(this.AreaOfUsage).Value + EFTProperties<AuthorizationProcessingRequirementsEnum>.Value(this.AuthorizationProcessingRequirements).Value + EFTProperties<ServicesAndPINRequirementsEnum>.Value(this.ServicesAndPINRequirements).Value;
		}

		public static ServiceRestrictionCode FromString(string serviceRestrictionCode)
		{
			return new ServiceRestrictionCode(serviceRestrictionCode);
		}

		private void InitStrings(string areaOfUsage, string authProcessingRequirements, string servicesAndPINRequirements)
		{
			this.AreaOfUsage = EFTProperties<AreaOfUsageEnum>.Enum(areaOfUsage);
			this.AuthorizationProcessingRequirements = EFTProperties<AuthorizationProcessingRequirementsEnum>.Enum(authProcessingRequirements);
			this.ServicesAndPINRequirements = EFTProperties<ServicesAndPINRequirementsEnum>.Enum(servicesAndPINRequirements);
		}
	}
}
