using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class CardVerificationResult : EFTProperties<CardVerificationResultEnum>
	{
		public static EFTConstant<string> CVV2ValidCVVValidOrNotAvailable;

		public static EFTConstant<string> CVV2InvalidCVVValidOrNotAvailable;

		public static EFTConstant<string> UnableToProcessCVV2CVVValidOrNotAvailable;

		public static EFTConstant<string> IssuerUnregisteredToProcessCVV2CVVValidOrNotAvailable;

		public static EFTConstant<string> CVVInvalid;

		static CardVerificationResult()
		{
			CardVerificationResult.CVV2ValidCVVValidOrNotAvailable = new EFTConstant<string>("M");
			CardVerificationResult.CVV2InvalidCVVValidOrNotAvailable = new EFTConstant<string>("N");
			CardVerificationResult.UnableToProcessCVV2CVVValidOrNotAvailable = new EFTConstant<string>("P");
			CardVerificationResult.IssuerUnregisteredToProcessCVV2CVVValidOrNotAvailable = new EFTConstant<string>("U");
			CardVerificationResult.CVVInvalid = new EFTConstant<string>("Y");
			EFTProperties<CardVerificationResultEnum>.Add(CardVerificationResultEnum.CVV2InvalidCVVValidOrNotAvailable, CardVerificationResult.CVV2InvalidCVVValidOrNotAvailable);
			EFTProperties<CardVerificationResultEnum>.Add(CardVerificationResultEnum.CVV2ValidCVVValidOrNotAvailable, CardVerificationResult.CVV2ValidCVVValidOrNotAvailable);
			EFTProperties<CardVerificationResultEnum>.Add(CardVerificationResultEnum.CVVInvalid, CardVerificationResult.CVVInvalid);
			EFTProperties<CardVerificationResultEnum>.Add(CardVerificationResultEnum.IssuerUnregisteredToProcessCVV2CVVValidOrNotAvailable, CardVerificationResult.IssuerUnregisteredToProcessCVV2CVVValidOrNotAvailable);
			EFTProperties<CardVerificationResultEnum>.Add(CardVerificationResultEnum.UnableToProcessCVV2CVVValidOrNotAvailable, CardVerificationResult.UnableToProcessCVV2CVVValidOrNotAvailable);
		}
	}
}
