using System;

namespace Messages.Postbridge.Enums
{
	public enum CardVerificationResultEnum
	{
		CVV2ValidCVVValidOrNotAvailable,
		CVV2InvalidCVVValidOrNotAvailable,
		UnableToProcessCVV2CVVValidOrNotAvailable,
		IssuerUnregisteredToProcessCVV2CVVValidOrNotAvailable,
		CVVInvalid
	}
}
