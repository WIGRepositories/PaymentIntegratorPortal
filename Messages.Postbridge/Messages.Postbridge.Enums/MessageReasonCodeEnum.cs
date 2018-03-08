using System;

namespace Messages.Postbridge.Enums
{
	public enum MessageReasonCodeEnum
	{
		StandInProcessing,
		CardIssuerUnavailable,
		UnderFloorLimit,
		PINRelatedFailure,
		ChangeDispensed,
		IOUReceiptPrinted,
		OverFloorLimit,
		NegativeCard,
		LostCard,
		StolenCard,
		UndeliveredCard,
		CounterfeitCard,
		LostPIN,
		CustomerCancellation,
		CompletedPartially,
		UnableToDeliverMessageToThePointOfService,
		SuspectedMalfunctionNoCashDispensed,
		InvalidResponseNoActionTaken,
		TimeoutWaitingForResponse,
		InvalidCVV2,
		InvalidAddress
	}
}
