using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class MessageReasonCode : EFTProperties<MessageReasonCodeEnum>
	{
		public static EFTConstant<string> StandInProcessing;

		public static EFTConstant<string> CardIssuerUnavailable;

		public static EFTConstant<string> UnderFloorLimit;

		public static EFTConstant<string> PINRelatedFailure;

		public static EFTConstant<string> ChangeDispensed;

		public static EFTConstant<string> IOUReceiptPrinted;

		public static EFTConstant<string> OverFloorLimit;

		public static EFTConstant<string> NegativeCard;

		public static EFTConstant<string> LostCard;

		public static EFTConstant<string> StolenCard;

		public static EFTConstant<string> UndeliveredCard;

		public static EFTConstant<string> CounterfeitCard;

		public static EFTConstant<string> LostPIN;

		public static EFTConstant<string> CustomerCancellation;

		public static EFTConstant<string> CompletedPartially;

		public static EFTConstant<string> UnableToDeliverMessageToThePointOfService;

		public static EFTConstant<string> SuspectedMalfunctionNoCashDispensed;

		public static EFTConstant<string> InvalidResponseNoActionTaken;

		public static EFTConstant<string> TimeoutWaitingForResponse;

		public static EFTConstant<string> InvalidCVV2;

		public static EFTConstant<string> InvalidAddress;

		static MessageReasonCode()
		{
			MessageReasonCode.StandInProcessing = new EFTConstant<string>("1000");
			MessageReasonCode.CardIssuerUnavailable = new EFTConstant<string>("1003");
			MessageReasonCode.UnderFloorLimit = new EFTConstant<string>("1006");
			MessageReasonCode.PINRelatedFailure = new EFTConstant<string>("1376");
			MessageReasonCode.ChangeDispensed = new EFTConstant<string>("1377");
			MessageReasonCode.IOUReceiptPrinted = new EFTConstant<string>("1378");
			MessageReasonCode.OverFloorLimit = new EFTConstant<string>("1510");
			MessageReasonCode.NegativeCard = new EFTConstant<string>("1800");
			MessageReasonCode.LostCard = new EFTConstant<string>("3000");
			MessageReasonCode.StolenCard = new EFTConstant<string>("3001");
			MessageReasonCode.UndeliveredCard = new EFTConstant<string>("3002");
			MessageReasonCode.CounterfeitCard = new EFTConstant<string>("3003");
			MessageReasonCode.LostPIN = new EFTConstant<string>("3700");
			MessageReasonCode.CustomerCancellation = new EFTConstant<string>("4000");
			MessageReasonCode.CompletedPartially = new EFTConstant<string>("4004");
			MessageReasonCode.UnableToDeliverMessageToThePointOfService = new EFTConstant<string>("4013");
			MessageReasonCode.SuspectedMalfunctionNoCashDispensed = new EFTConstant<string>("4017");
			MessageReasonCode.InvalidResponseNoActionTaken = new EFTConstant<string>("4020");
			MessageReasonCode.TimeoutWaitingForResponse = new EFTConstant<string>("4021");
			MessageReasonCode.InvalidCVV2 = new EFTConstant<string>("4351");
			MessageReasonCode.InvalidAddress = new EFTConstant<string>("4352");
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.CardIssuerUnavailable, MessageReasonCode.CardIssuerUnavailable);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.ChangeDispensed, MessageReasonCode.ChangeDispensed);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.CompletedPartially, MessageReasonCode.CompletedPartially);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.CounterfeitCard, MessageReasonCode.CounterfeitCard);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.CustomerCancellation, MessageReasonCode.CustomerCancellation);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.InvalidAddress, MessageReasonCode.InvalidAddress);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.InvalidCVV2, MessageReasonCode.InvalidCVV2);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.InvalidResponseNoActionTaken, MessageReasonCode.InvalidResponseNoActionTaken);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.IOUReceiptPrinted, MessageReasonCode.IOUReceiptPrinted);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.LostCard, MessageReasonCode.LostCard);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.LostPIN, MessageReasonCode.LostPIN);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.NegativeCard, MessageReasonCode.NegativeCard);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.OverFloorLimit, MessageReasonCode.OverFloorLimit);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.PINRelatedFailure, MessageReasonCode.PINRelatedFailure);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.StandInProcessing, MessageReasonCode.StandInProcessing);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.StolenCard, MessageReasonCode.StolenCard);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.SuspectedMalfunctionNoCashDispensed, MessageReasonCode.SuspectedMalfunctionNoCashDispensed);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.TimeoutWaitingForResponse, MessageReasonCode.TimeoutWaitingForResponse);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.UnableToDeliverMessageToThePointOfService, MessageReasonCode.UnableToDeliverMessageToThePointOfService);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.UndeliveredCard, MessageReasonCode.UndeliveredCard);
			EFTProperties<MessageReasonCodeEnum>.Add(MessageReasonCodeEnum.UnderFloorLimit, MessageReasonCode.UnderFloorLimit);
		}
	}
}
