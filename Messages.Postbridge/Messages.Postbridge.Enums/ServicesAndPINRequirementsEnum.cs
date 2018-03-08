using System;

namespace Messages.Postbridge.Enums
{
	public enum ServicesAndPINRequirementsEnum
	{
		PINRequired,
		NoRestrictions,
		GoodsAndServicesOnly,
		PINRequiredATMOnly,
		PINRequiredGoodsAndServicesOnlyAtPOSCashAtATM,
		PINRequiredIfPINPadPresent,
		PINRequiredIfPINPadPresentGoodsAndServicesOnlyAtPOSCashAtATM
	}
}
