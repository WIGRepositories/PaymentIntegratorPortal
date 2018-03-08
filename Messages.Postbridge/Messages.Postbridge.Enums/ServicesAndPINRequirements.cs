using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class ServicesAndPINRequirements : EFTProperties<ServicesAndPINRequirementsEnum>
	{
		public static EFTConstant<string> PINRequired;

		public static EFTConstant<string> NoRestrictions;

		public static EFTConstant<string> GoodsAndServicesOnly;

		public static EFTConstant<string> PINRequiredATMOnly;

		public static EFTConstant<string> PINRequiredGoodsAndServicesOnlyAtPOSCashAtATM;

		public static EFTConstant<string> PINRequiredIfPINPadPresent;

		public static EFTConstant<string> PINRequiredIfPINPadPresentGoodsAndServicesOnlyAtPOSCashAtATM;

		static ServicesAndPINRequirements()
		{
			ServicesAndPINRequirements.PINRequired = new EFTConstant<string>("0");
			ServicesAndPINRequirements.NoRestrictions = new EFTConstant<string>("1");
			ServicesAndPINRequirements.GoodsAndServicesOnly = new EFTConstant<string>("2");
			ServicesAndPINRequirements.PINRequiredATMOnly = new EFTConstant<string>("3");
			ServicesAndPINRequirements.PINRequiredGoodsAndServicesOnlyAtPOSCashAtATM = new EFTConstant<string>("5");
			ServicesAndPINRequirements.PINRequiredIfPINPadPresent = new EFTConstant<string>("6");
			ServicesAndPINRequirements.PINRequiredIfPINPadPresentGoodsAndServicesOnlyAtPOSCashAtATM = new EFTConstant<string>("7");
			EFTProperties<ServicesAndPINRequirementsEnum>.Add(ServicesAndPINRequirementsEnum.GoodsAndServicesOnly, ServicesAndPINRequirements.GoodsAndServicesOnly);
			EFTProperties<ServicesAndPINRequirementsEnum>.Add(ServicesAndPINRequirementsEnum.NoRestrictions, ServicesAndPINRequirements.NoRestrictions);
			EFTProperties<ServicesAndPINRequirementsEnum>.Add(ServicesAndPINRequirementsEnum.PINRequired, ServicesAndPINRequirements.PINRequired);
			EFTProperties<ServicesAndPINRequirementsEnum>.Add(ServicesAndPINRequirementsEnum.PINRequiredATMOnly, ServicesAndPINRequirements.PINRequiredATMOnly);
			EFTProperties<ServicesAndPINRequirementsEnum>.Add(ServicesAndPINRequirementsEnum.PINRequiredGoodsAndServicesOnlyAtPOSCashAtATM, ServicesAndPINRequirements.PINRequiredGoodsAndServicesOnlyAtPOSCashAtATM);
			EFTProperties<ServicesAndPINRequirementsEnum>.Add(ServicesAndPINRequirementsEnum.PINRequiredIfPINPadPresent, ServicesAndPINRequirements.PINRequiredIfPINPadPresent);
			EFTProperties<ServicesAndPINRequirementsEnum>.Add(ServicesAndPINRequirementsEnum.PINRequiredIfPINPadPresentGoodsAndServicesOnlyAtPOSCashAtATM, ServicesAndPINRequirements.PINRequiredIfPINPadPresentGoodsAndServicesOnlyAtPOSCashAtATM);
		}
	}
}
