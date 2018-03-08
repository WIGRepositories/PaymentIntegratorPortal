using Messages.Core;
using Messages.Postbridge.Helpers;
using System;
using System.Collections.Generic;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class MessageType : EFTProperties<MessageTypeEnum>
	{
		public static EFTConstant<string> AuthorizationRequest;

		public static EFTConstant<string> AuthorizationRequestRepeat;

		public static EFTConstant<string> AuthorizationResponse;

		public static EFTConstant<string> AuthorizationAdvice;

		public static EFTConstant<string> AuthorizationAdviceRepeat;

		public static EFTConstant<string> AuthorizationAdviceResponse;

		public static EFTConstant<string> TransactionRequest;

		public static EFTConstant<string> TransactionRequestRepeat;

		public static EFTConstant<string> TransactionCompletion;

		public static EFTConstant<string> TransactionCompletionRepeat;

		public static EFTConstant<string> TransactionResponse;

		public static EFTConstant<string> TransactionCompletionResponse;

		public static EFTConstant<string> TransactionAdvice;

		public static EFTConstant<string> TransactionAdviceRepeat;

		public static EFTConstant<string> TransactionAdviceResponse;

		public static EFTConstant<string> AcquirerFileUpdateAdvice;

		public static EFTConstant<string> AcquirerFileUpdateAdviceRepeat;

		public static EFTConstant<string> IssuerFileUpdateAdvice;

		public static EFTConstant<string> IssuerFileUpdateAdviceRepeat;

		public static EFTConstant<string> AcquirerFileUpdateAdviceResponse;

		public static EFTConstant<string> IssuerFileUpdateAdviceResponse;

		public static EFTConstant<string> ReversalRequest;

		public static EFTConstant<string> ReversalRequestRepeat;

		public static EFTConstant<string> ReversalResponse;

		public static EFTConstant<string> ReversalAdvice;

		public static EFTConstant<string> ReversalAdviceRepeat;

		public static EFTConstant<string> ReversalAdviceResponse;

		public static EFTConstant<string> AcquirerReconciliationRequest;

		public static EFTConstant<string> AcquirerReconciliationRequestRepeat;

		public static EFTConstant<string> CardIssuerReconciliationRequest;

		public static EFTConstant<string> CardIssuerReconciliationRequestRepeat;

		public static EFTConstant<string> AcquirerReconciliationResponse;

		public static EFTConstant<string> CardIssuerReconciliationResponse;

		public static EFTConstant<string> AcquirerReconciliationAdvice;

		public static EFTConstant<string> AcquirerReconciliationAdviceRepeat;

		public static EFTConstant<string> CardIssuerReconciliationAdvice;

		public static EFTConstant<string> CardIssuerReconciliationAdviceRepeat;

		public static EFTConstant<string> AcquirerReconciliationAdviceResponse;

		public static EFTConstant<string> CardIssuerReconciliationAdviceResponse;

		public static EFTConstant<string> AdministrativeRequest;

		public static EFTConstant<string> AdministrativeRequestRepeat;

		public static EFTConstant<string> AdministrativeResponse;

		public static EFTConstant<string> AdministrationAdvice;

		public static EFTConstant<string> AdministrationAdviceRepeat;

		public static EFTConstant<string> AdministrativeAdviceResponse;

		public static EFTConstant<string> NetworkManagementRequest;

		public static EFTConstant<string> NetworkManagementRequestRepeat;

		public static EFTConstant<string> NetworkManagementResponse;

		public static EFTConstant<string> AuthorizationNotificationAdvice;

		public static EFTConstant<string> AuthorizationNotificationAdviceResponse;

		public static EFTConstant<string> TransactionNotificationAdvice;

		public static EFTConstant<string> TransactionNotificationAdviceResponse;

		public static EFTConstant<string> ReversalNotificationAdvice;

		public static EFTConstant<string> ReversalNotificationAdviceResponse;

		public static EFTConstant<string> AdministrationNotificationAdvice;

		public static EFTConstant<string> AdministrationNotificationAdviceResponse;

		private static Dictionary<MessageTypeEnum, MessageTypeEnum> responseMsgType;

		private static Dictionary<string, MessageTypeEnum> responseString;

		public static MessageTypeEnum GetResponse(MessageTypeEnum msgType)
		{
			return MessageType.responseMsgType[msgType];
		}

		public static MessageTypeEnum GetResponse(string msgType)
		{
			return MessageType.responseString[msgType];
		}

		public static bool IsNetworkManagement(MessageTypeEnum msgType)
		{
			return msgType == MessageTypeEnum.NetworkManagementRequest || msgType == MessageTypeEnum.NetworkManagementRequestRepeat || msgType == MessageTypeEnum.NetworkManagementResponse;
		}

		static MessageType()
		{
			MessageType.AuthorizationRequest = new EFTConstant<string>("0100");
			MessageType.AuthorizationRequestRepeat = new EFTConstant<string>("0101");
			MessageType.AuthorizationResponse = new EFTConstant<string>("0110");
			MessageType.AuthorizationAdvice = new EFTConstant<string>("0120");
			MessageType.AuthorizationAdviceRepeat = new EFTConstant<string>("0121");
			MessageType.AuthorizationAdviceResponse = new EFTConstant<string>("0130");
			MessageType.TransactionRequest = new EFTConstant<string>("0200");
			MessageType.TransactionRequestRepeat = new EFTConstant<string>("0201");
			MessageType.TransactionCompletion = new EFTConstant<string>("0202");
			MessageType.TransactionCompletionRepeat = new EFTConstant<string>("0203");
			MessageType.TransactionResponse = new EFTConstant<string>("0210");
			MessageType.TransactionCompletionResponse = new EFTConstant<string>("0212");
			MessageType.TransactionAdvice = new EFTConstant<string>("0220");
			MessageType.TransactionAdviceRepeat = new EFTConstant<string>("0221");
			MessageType.TransactionAdviceResponse = new EFTConstant<string>("0230");
			MessageType.AcquirerFileUpdateAdvice = new EFTConstant<string>("0320");
			MessageType.AcquirerFileUpdateAdviceRepeat = new EFTConstant<string>("0321");
			MessageType.IssuerFileUpdateAdvice = new EFTConstant<string>("0322");
			MessageType.IssuerFileUpdateAdviceRepeat = new EFTConstant<string>("0323");
			MessageType.AcquirerFileUpdateAdviceResponse = new EFTConstant<string>("0330");
			MessageType.IssuerFileUpdateAdviceResponse = new EFTConstant<string>("0332");
			MessageType.ReversalRequest = new EFTConstant<string>("0400");
			MessageType.ReversalRequestRepeat = new EFTConstant<string>("0401");
			MessageType.ReversalResponse = new EFTConstant<string>("0410");
			MessageType.ReversalAdvice = new EFTConstant<string>("0420");
			MessageType.ReversalAdviceRepeat = new EFTConstant<string>("0421");
			MessageType.ReversalAdviceResponse = new EFTConstant<string>("0430");
			MessageType.AcquirerReconciliationRequest = new EFTConstant<string>("0500");
			MessageType.AcquirerReconciliationRequestRepeat = new EFTConstant<string>("0501");
			MessageType.CardIssuerReconciliationRequest = new EFTConstant<string>("0502");
			MessageType.CardIssuerReconciliationRequestRepeat = new EFTConstant<string>("0503");
			MessageType.AcquirerReconciliationResponse = new EFTConstant<string>("0510");
			MessageType.CardIssuerReconciliationResponse = new EFTConstant<string>("0512");
			MessageType.AcquirerReconciliationAdvice = new EFTConstant<string>("0520");
			MessageType.AcquirerReconciliationAdviceRepeat = new EFTConstant<string>("0521");
			MessageType.CardIssuerReconciliationAdvice = new EFTConstant<string>("0522");
			MessageType.CardIssuerReconciliationAdviceRepeat = new EFTConstant<string>("0523");
			MessageType.AcquirerReconciliationAdviceResponse = new EFTConstant<string>("0530");
			MessageType.CardIssuerReconciliationAdviceResponse = new EFTConstant<string>("0532");
			MessageType.AdministrativeRequest = new EFTConstant<string>("0600");
			MessageType.AdministrativeRequestRepeat = new EFTConstant<string>("0601");
			MessageType.AdministrativeResponse = new EFTConstant<string>("0610");
			MessageType.AdministrationAdvice = new EFTConstant<string>("0620");
			MessageType.AdministrationAdviceRepeat = new EFTConstant<string>("0621");
			MessageType.AdministrativeAdviceResponse = new EFTConstant<string>("0630");
			MessageType.NetworkManagementRequest = new EFTConstant<string>("0800");
			MessageType.NetworkManagementRequestRepeat = new EFTConstant<string>("0801");
			MessageType.NetworkManagementResponse = new EFTConstant<string>("0810");
			MessageType.AuthorizationNotificationAdvice = new EFTConstant<string>("9120");
			MessageType.AuthorizationNotificationAdviceResponse = new EFTConstant<string>("9130");
			MessageType.TransactionNotificationAdvice = new EFTConstant<string>("9220");
			MessageType.TransactionNotificationAdviceResponse = new EFTConstant<string>("9230");
			MessageType.ReversalNotificationAdvice = new EFTConstant<string>("9420");
			MessageType.ReversalNotificationAdviceResponse = new EFTConstant<string>("9430");
			MessageType.AdministrationNotificationAdvice = new EFTConstant<string>("9620");
			MessageType.AdministrationNotificationAdviceResponse = new EFTConstant<string>("9630");
			MessageType.responseMsgType = new Dictionary<MessageTypeEnum, MessageTypeEnum>();
			MessageType.responseString = new Dictionary<string, MessageTypeEnum>();
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AcquirerFileUpdateAdvice, MessageType.AcquirerFileUpdateAdvice);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AcquirerFileUpdateAdviceRepeat, MessageType.AcquirerFileUpdateAdviceRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.AcquirerFileUpdateAdvice, MessageTypeEnum.AcquirerFileUpdateAdviceResponse);
			MessageType.AddResponsePair(MessageTypeEnum.AcquirerFileUpdateAdviceRepeat, MessageTypeEnum.AcquirerFileUpdateAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AcquirerFileUpdateAdviceResponse, MessageType.AcquirerFileUpdateAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AcquirerReconciliationAdvice, MessageType.AcquirerReconciliationAdvice);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AcquirerReconciliationAdviceRepeat, MessageType.AcquirerReconciliationAdviceRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.AcquirerReconciliationAdvice, MessageTypeEnum.AcquirerReconciliationAdviceResponse);
			MessageType.AddResponsePair(MessageTypeEnum.AcquirerReconciliationAdviceRepeat, MessageTypeEnum.AcquirerReconciliationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AcquirerReconciliationAdviceResponse, MessageType.AcquirerReconciliationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AcquirerReconciliationRequest, MessageType.AcquirerReconciliationRequest);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AcquirerReconciliationRequestRepeat, MessageType.AcquirerReconciliationRequestRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.AcquirerReconciliationRequest, MessageTypeEnum.AcquirerReconciliationResponse);
			MessageType.AddResponsePair(MessageTypeEnum.AcquirerReconciliationRequestRepeat, MessageTypeEnum.AcquirerReconciliationResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AcquirerReconciliationResponse, MessageType.AcquirerReconciliationResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AdministrationAdvice, MessageType.AdministrationAdvice);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AdministrationAdviceRepeat, MessageType.AdministrationAdviceRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.AdministrationAdvice, MessageTypeEnum.AdministrativeAdviceResponse);
			MessageType.AddResponsePair(MessageTypeEnum.AdministrationAdviceRepeat, MessageTypeEnum.AdministrativeAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AdministrationNotificationAdvice, MessageType.AdministrationNotificationAdvice);
			MessageType.AddResponsePair(MessageTypeEnum.AdministrationNotificationAdvice, MessageTypeEnum.AdministrationNotificationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AdministrationNotificationAdviceResponse, MessageType.AdministrationNotificationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AdministrativeAdviceResponse, MessageType.AdministrativeAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AdministrativeRequest, MessageType.AdministrativeRequest);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AdministrativeRequestRepeat, MessageType.AdministrativeRequestRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.AdministrativeRequest, MessageTypeEnum.AdministrativeResponse);
			MessageType.AddResponsePair(MessageTypeEnum.AdministrativeRequestRepeat, MessageTypeEnum.AdministrativeResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AdministrativeResponse, MessageType.AdministrativeResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AuthorizationAdvice, MessageType.AuthorizationAdvice);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AuthorizationAdviceRepeat, MessageType.AuthorizationAdviceRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.AuthorizationAdvice, MessageTypeEnum.AuthorizationAdviceResponse);
			MessageType.AddResponsePair(MessageTypeEnum.AuthorizationAdviceRepeat, MessageTypeEnum.AuthorizationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AuthorizationAdviceResponse, MessageType.AuthorizationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AuthorizationNotificationAdvice, MessageType.AuthorizationNotificationAdvice);
			MessageType.AddResponsePair(MessageTypeEnum.AuthorizationNotificationAdvice, MessageTypeEnum.AuthorizationNotificationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AuthorizationNotificationAdviceResponse, MessageType.AuthorizationNotificationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AuthorizationRequest, MessageType.AuthorizationRequest);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AuthorizationRequestRepeat, MessageType.AuthorizationRequestRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.AuthorizationRequest, MessageTypeEnum.AuthorizationResponse);
			MessageType.AddResponsePair(MessageTypeEnum.AuthorizationRequestRepeat, MessageTypeEnum.AuthorizationResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.AuthorizationResponse, MessageType.AuthorizationResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.CardIssuerReconciliationAdvice, MessageType.CardIssuerReconciliationAdvice);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.CardIssuerReconciliationAdviceRepeat, MessageType.CardIssuerReconciliationAdviceRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.CardIssuerReconciliationAdvice, MessageTypeEnum.CardIssuerReconciliationAdviceResponse);
			MessageType.AddResponsePair(MessageTypeEnum.CardIssuerReconciliationAdviceRepeat, MessageTypeEnum.CardIssuerReconciliationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.CardIssuerReconciliationAdviceResponse, MessageType.CardIssuerReconciliationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.CardIssuerReconciliationRequest, MessageType.CardIssuerReconciliationRequest);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.CardIssuerReconciliationRequestRepeat, MessageType.CardIssuerReconciliationRequestRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.CardIssuerReconciliationRequest, MessageTypeEnum.CardIssuerReconciliationResponse);
			MessageType.AddResponsePair(MessageTypeEnum.CardIssuerReconciliationRequestRepeat, MessageTypeEnum.CardIssuerReconciliationResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.CardIssuerReconciliationResponse, MessageType.CardIssuerReconciliationResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.IssuerFileUpdateAdvice, MessageType.IssuerFileUpdateAdvice);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.IssuerFileUpdateAdviceRepeat, MessageType.IssuerFileUpdateAdviceRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.IssuerFileUpdateAdvice, MessageTypeEnum.IssuerFileUpdateAdviceResponse);
			MessageType.AddResponsePair(MessageTypeEnum.IssuerFileUpdateAdviceRepeat, MessageTypeEnum.IssuerFileUpdateAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.IssuerFileUpdateAdviceResponse, MessageType.IssuerFileUpdateAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.NetworkManagementRequest, MessageType.NetworkManagementRequest);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.NetworkManagementRequestRepeat, MessageType.NetworkManagementRequestRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.NetworkManagementRequest, MessageTypeEnum.NetworkManagementResponse);
			MessageType.AddResponsePair(MessageTypeEnum.NetworkManagementRequestRepeat, MessageTypeEnum.NetworkManagementResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.NetworkManagementResponse, MessageType.NetworkManagementResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.ReversalAdvice, MessageType.ReversalAdvice);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.ReversalAdviceRepeat, MessageType.ReversalAdviceRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.ReversalAdvice, MessageTypeEnum.ReversalAdviceResponse);
			MessageType.AddResponsePair(MessageTypeEnum.ReversalAdviceRepeat, MessageTypeEnum.ReversalAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.ReversalAdviceResponse, MessageType.ReversalAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.ReversalNotificationAdvice, MessageType.ReversalNotificationAdvice);
			MessageType.AddResponsePair(MessageTypeEnum.ReversalNotificationAdvice, MessageTypeEnum.ReversalNotificationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.ReversalNotificationAdviceResponse, MessageType.ReversalNotificationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.ReversalRequest, MessageType.ReversalRequest);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.ReversalRequestRepeat, MessageType.ReversalRequestRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.ReversalRequest, MessageTypeEnum.ReversalResponse);
			MessageType.AddResponsePair(MessageTypeEnum.ReversalRequestRepeat, MessageTypeEnum.ReversalResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.ReversalResponse, MessageType.ReversalResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionAdvice, MessageType.TransactionAdvice);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionAdviceRepeat, MessageType.TransactionAdviceRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.TransactionAdvice, MessageTypeEnum.TransactionAdviceResponse);
			MessageType.AddResponsePair(MessageTypeEnum.TransactionAdviceRepeat, MessageTypeEnum.TransactionAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionAdviceResponse, MessageType.TransactionAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionCompletion, MessageType.TransactionCompletion);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionCompletionRepeat, MessageType.TransactionCompletionRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.TransactionCompletion, MessageTypeEnum.TransactionCompletionResponse);
			MessageType.AddResponsePair(MessageTypeEnum.TransactionCompletionRepeat, MessageTypeEnum.TransactionCompletionResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionCompletionResponse, MessageType.TransactionCompletionResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionNotificationAdvice, MessageType.TransactionNotificationAdvice);
			MessageType.AddResponsePair(MessageTypeEnum.TransactionNotificationAdvice, MessageTypeEnum.TransactionNotificationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionNotificationAdviceResponse, MessageType.TransactionNotificationAdviceResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionRequest, MessageType.TransactionRequest);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionRequestRepeat, MessageType.TransactionRequestRepeat);
			MessageType.AddResponsePair(MessageTypeEnum.TransactionRequest, MessageTypeEnum.TransactionResponse);
			MessageType.AddResponsePair(MessageTypeEnum.TransactionRequestRepeat, MessageTypeEnum.TransactionResponse);
			EFTProperties<MessageTypeEnum>.Add(MessageTypeEnum.TransactionResponse, MessageType.TransactionResponse);
		}

		private static void AddResponsePair(MessageTypeEnum request, MessageTypeEnum response)
		{
			MessageType.responseMsgType.Add(request, response);
			MessageType.responseString.Add(EFTProperties<MessageTypeEnum>.Value(request).Value, response);
		}
	}
}
