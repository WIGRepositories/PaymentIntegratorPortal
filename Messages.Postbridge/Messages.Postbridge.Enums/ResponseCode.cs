using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class ResponseCode : EFTProperties<ResponseCodeEnum>
	{
		public static EFTConstant<string> Approved;

		public static EFTConstant<string> ReferToCardIssuer;

		public static EFTConstant<string> ReferToCardIssuerSpecialCondition;

		public static EFTConstant<string> InvalidMerchant;

		public static EFTConstant<string> PickupCard;

		public static EFTConstant<string> DoNotHonor;

		public static EFTConstant<string> Error;

		public static EFTConstant<string> PickUpSpecialCondition;

		public static EFTConstant<string> HonorWithIdentification;

		public static EFTConstant<string> RequestInProgress;

		public static EFTConstant<string> ApprovedPartial;

		public static EFTConstant<string> ApprovedVIP;

		public static EFTConstant<string> InvalidTransaction;

		public static EFTConstant<string> InvalidAmount;

		public static EFTConstant<string> InvalidCardNumber;

		public static EFTConstant<string> NoSuchIssuer;

		public static EFTConstant<string> ApprovedUpdateTrack3;

		public static EFTConstant<string> CustomerCancellation;

		public static EFTConstant<string> CustomerDispute;

		public static EFTConstant<string> ReenterTransaction;

		public static EFTConstant<string> InvalidResponse;

		public static EFTConstant<string> NoActionTaken;

		public static EFTConstant<string> SuspectedMalfunction;

		public static EFTConstant<string> UnacceptableTransactionFee;

		public static EFTConstant<string> FileUpdateNotSupported;

		public static EFTConstant<string> UnableToLocateRecord;

		public static EFTConstant<string> DuplicateRecord;

		public static EFTConstant<string> FileUpdateFieldEditError;

		public static EFTConstant<string> FileUpdateLocked;

		public static EFTConstant<string> FileUpdateFailed;

		public static EFTConstant<string> FormatError;

		public static EFTConstant<string> BankNotSupported;

		public static EFTConstant<string> CompletedPartially;

		public static EFTConstant<string> ExpiredCardPickUp;

		public static EFTConstant<string> SuspectedFraudPickUp;

		public static EFTConstant<string> ContactAcquirerPickUp;

		public static EFTConstant<string> RestrictedCardPickUp;

		public static EFTConstant<string> CallAcquirerSecurityPickUp;

		public static EFTConstant<string> PINTriesExceededPickUp;

		public static EFTConstant<string> NoCreditAccount;

		public static EFTConstant<string> FunctionNotSupported;

		public static EFTConstant<string> LostCardPickUp;

		public static EFTConstant<string> NoUniversalAccount;

		public static EFTConstant<string> StolenCardPickUp;

		public static EFTConstant<string> NoInvestmentAccount;

		public static EFTConstant<string> AccountClosed;

		public static EFTConstant<string> IdentificationRequired;

		public static EFTConstant<string> IdentificationCrossCheckRequired;

		public static EFTConstant<string> InsufficientFunds;

		public static EFTConstant<string> NoCheckAccount;

		public static EFTConstant<string> NoSavingsAccount;

		public static EFTConstant<string> ExpiredCard;

		public static EFTConstant<string> IncorrectPIN;

		public static EFTConstant<string> NoCardRecord;

		public static EFTConstant<string> TransactionNotPermittedToCardholder;

		public static EFTConstant<string> TransactionNotPermittedToTerminal;

		public static EFTConstant<string> SuspectedFraud;

		public static EFTConstant<string> ContactAcquirer;

		public static EFTConstant<string> ExceedsWithdrawalLimit;

		public static EFTConstant<string> RestrictedCard;

		public static EFTConstant<string> SecurityViolation;

		public static EFTConstant<string> OriginalAmountIncorrect;

		public static EFTConstant<string> ExceedsWithdrawalFrequency;

		public static EFTConstant<string> CallAcquirerSecurity;

		public static EFTConstant<string> HardCapture;

		public static EFTConstant<string> ResponseReceivedTooLate;

		public static EFTConstant<string> AdviceReceivedTooLate;

		public static EFTConstant<string> PINTriesExceeded;

		public static EFTConstant<string> InterveneBankApprovalRequired;

		public static EFTConstant<string> InterveneBankApprovalRequiredForPartialAmount;

		public static EFTConstant<string> CutoffInProgress;

		public static EFTConstant<string> IssuerOrSwitchInoperative;

		public static EFTConstant<string> RoutingError;

		public static EFTConstant<string> ViolationOfLaw;

		public static EFTConstant<string> DuplicateTransaction;

		public static EFTConstant<string> ReconcileError;

		public static EFTConstant<string> SystemMalfunction;

		public static EFTConstant<string> ExceedsCashLimit;

		public static EFTConstant<string> ATCNotIncremented;

		public static EFTConstant<string> ATCLimitExceeded;

		public static EFTConstant<string> ATCConfiguratioNError;

		public static EFTConstant<string> CVRCheckFailure;

		public static EFTConstant<string> CVRConfigurationError;

		public static EFTConstant<string> TVRCheckFailure;

		public static EFTConstant<string> TVRConfigurationError;

		public static EFTConstant<string> UnacceptablePIN;

		public static EFTConstant<string> PINChangeFailed;

		public static EFTConstant<string> PINUnblockFailed;

		public static EFTConstant<string> MACError;

		public static EFTConstant<string> PrepayError;

		static ResponseCode()
		{
			ResponseCode.Approved = new EFTConstant<string>("00");
			ResponseCode.ReferToCardIssuer = new EFTConstant<string>("01");
			ResponseCode.ReferToCardIssuerSpecialCondition = new EFTConstant<string>("02");
			ResponseCode.InvalidMerchant = new EFTConstant<string>("03");
			ResponseCode.PickupCard = new EFTConstant<string>("04");
			ResponseCode.DoNotHonor = new EFTConstant<string>("05");
			ResponseCode.Error = new EFTConstant<string>("06");
			ResponseCode.PickUpSpecialCondition = new EFTConstant<string>("07");
			ResponseCode.HonorWithIdentification = new EFTConstant<string>("08");
			ResponseCode.RequestInProgress = new EFTConstant<string>("09");
			ResponseCode.ApprovedPartial = new EFTConstant<string>("10");
			ResponseCode.ApprovedVIP = new EFTConstant<string>("11");
			ResponseCode.InvalidTransaction = new EFTConstant<string>("12");
			ResponseCode.InvalidAmount = new EFTConstant<string>("13");
			ResponseCode.InvalidCardNumber = new EFTConstant<string>("14");
			ResponseCode.NoSuchIssuer = new EFTConstant<string>("15");
			ResponseCode.ApprovedUpdateTrack3 = new EFTConstant<string>("16");
			ResponseCode.CustomerCancellation = new EFTConstant<string>("17");
			ResponseCode.CustomerDispute = new EFTConstant<string>("18");
			ResponseCode.ReenterTransaction = new EFTConstant<string>("19");
			ResponseCode.InvalidResponse = new EFTConstant<string>("20");
			ResponseCode.NoActionTaken = new EFTConstant<string>("21");
			ResponseCode.SuspectedMalfunction = new EFTConstant<string>("22");
			ResponseCode.UnacceptableTransactionFee = new EFTConstant<string>("23");
			ResponseCode.FileUpdateNotSupported = new EFTConstant<string>("24");
			ResponseCode.UnableToLocateRecord = new EFTConstant<string>("25");
			ResponseCode.DuplicateRecord = new EFTConstant<string>("26");
			ResponseCode.FileUpdateFieldEditError = new EFTConstant<string>("27");
			ResponseCode.FileUpdateLocked = new EFTConstant<string>("28");
			ResponseCode.FileUpdateFailed = new EFTConstant<string>("29");
			ResponseCode.FormatError = new EFTConstant<string>("30");
			ResponseCode.BankNotSupported = new EFTConstant<string>("31");
			ResponseCode.CompletedPartially = new EFTConstant<string>("32");
			ResponseCode.ExpiredCardPickUp = new EFTConstant<string>("33");
			ResponseCode.SuspectedFraudPickUp = new EFTConstant<string>("34");
			ResponseCode.ContactAcquirerPickUp = new EFTConstant<string>("35");
			ResponseCode.RestrictedCardPickUp = new EFTConstant<string>("36");
			ResponseCode.CallAcquirerSecurityPickUp = new EFTConstant<string>("37");
			ResponseCode.PINTriesExceededPickUp = new EFTConstant<string>("38");
			ResponseCode.NoCreditAccount = new EFTConstant<string>("39");
			ResponseCode.FunctionNotSupported = new EFTConstant<string>("40");
			ResponseCode.LostCardPickUp = new EFTConstant<string>("41");
			ResponseCode.NoUniversalAccount = new EFTConstant<string>("42");
			ResponseCode.StolenCardPickUp = new EFTConstant<string>("43");
			ResponseCode.NoInvestmentAccount = new EFTConstant<string>("44");
			ResponseCode.AccountClosed = new EFTConstant<string>("45");
			ResponseCode.IdentificationRequired = new EFTConstant<string>("46");
			ResponseCode.IdentificationCrossCheckRequired = new EFTConstant<string>("47");
			ResponseCode.InsufficientFunds = new EFTConstant<string>("51");
			ResponseCode.NoCheckAccount = new EFTConstant<string>("52");
			ResponseCode.NoSavingsAccount = new EFTConstant<string>("53");
			ResponseCode.ExpiredCard = new EFTConstant<string>("54");
			ResponseCode.IncorrectPIN = new EFTConstant<string>("55");
			ResponseCode.NoCardRecord = new EFTConstant<string>("56");
			ResponseCode.TransactionNotPermittedToCardholder = new EFTConstant<string>("57");
			ResponseCode.TransactionNotPermittedToTerminal = new EFTConstant<string>("58");
			ResponseCode.SuspectedFraud = new EFTConstant<string>("59");
			ResponseCode.ContactAcquirer = new EFTConstant<string>("60");
			ResponseCode.ExceedsWithdrawalLimit = new EFTConstant<string>("61");
			ResponseCode.RestrictedCard = new EFTConstant<string>("62");
			ResponseCode.SecurityViolation = new EFTConstant<string>("63");
			ResponseCode.OriginalAmountIncorrect = new EFTConstant<string>("64");
			ResponseCode.ExceedsWithdrawalFrequency = new EFTConstant<string>("65");
			ResponseCode.CallAcquirerSecurity = new EFTConstant<string>("66");
			ResponseCode.HardCapture = new EFTConstant<string>("67");
			ResponseCode.ResponseReceivedTooLate = new EFTConstant<string>("68");
			ResponseCode.AdviceReceivedTooLate = new EFTConstant<string>("69");
			ResponseCode.PINTriesExceeded = new EFTConstant<string>("75");
			ResponseCode.InterveneBankApprovalRequired = new EFTConstant<string>("77");
			ResponseCode.InterveneBankApprovalRequiredForPartialAmount = new EFTConstant<string>("78");
			ResponseCode.CutoffInProgress = new EFTConstant<string>("90");
			ResponseCode.IssuerOrSwitchInoperative = new EFTConstant<string>("91");
			ResponseCode.RoutingError = new EFTConstant<string>("92");
			ResponseCode.ViolationOfLaw = new EFTConstant<string>("93");
			ResponseCode.DuplicateTransaction = new EFTConstant<string>("94");
			ResponseCode.ReconcileError = new EFTConstant<string>("95");
			ResponseCode.SystemMalfunction = new EFTConstant<string>("96");
			ResponseCode.ExceedsCashLimit = new EFTConstant<string>("98");
			ResponseCode.ATCNotIncremented = new EFTConstant<string>("A1");
			ResponseCode.ATCLimitExceeded = new EFTConstant<string>("A2");
			ResponseCode.ATCConfiguratioNError = new EFTConstant<string>("A3");
			ResponseCode.CVRCheckFailure = new EFTConstant<string>("A4");
			ResponseCode.CVRConfigurationError = new EFTConstant<string>("A5");
			ResponseCode.TVRCheckFailure = new EFTConstant<string>("A6");
			ResponseCode.TVRConfigurationError = new EFTConstant<string>("A7");
			ResponseCode.UnacceptablePIN = new EFTConstant<string>("C0");
			ResponseCode.PINChangeFailed = new EFTConstant<string>("C1");
			ResponseCode.PINUnblockFailed = new EFTConstant<string>("C2");
			ResponseCode.MACError = new EFTConstant<string>("D1");
			ResponseCode.PrepayError = new EFTConstant<string>("E1");
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.AccountClosed, ResponseCode.AccountClosed);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.AdviceReceivedTooLate, ResponseCode.AdviceReceivedTooLate);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.Approved, ResponseCode.Approved);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ApprovedPartial, ResponseCode.ApprovedPartial);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ApprovedUpdateTrack3, ResponseCode.ApprovedUpdateTrack3);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ApprovedVIP, ResponseCode.ApprovedVIP);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ATCConfiguratioNError, ResponseCode.ATCConfiguratioNError);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ATCLimitExceeded, ResponseCode.ATCLimitExceeded);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ATCNotIncremented, ResponseCode.ATCNotIncremented);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.BankNotSupported, ResponseCode.BankNotSupported);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.CallAcquirerSecurity, ResponseCode.CallAcquirerSecurity);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.CallAcquirerSecurityPickUp, ResponseCode.CallAcquirerSecurityPickUp);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.CompletedPartially, ResponseCode.CompletedPartially);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ContactAcquirer, ResponseCode.ContactAcquirer);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ContactAcquirerPickUp, ResponseCode.ContactAcquirerPickUp);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.CustomerCancellation, ResponseCode.CustomerCancellation);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.CustomerDispute, ResponseCode.CustomerDispute);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.CutoffInProgress, ResponseCode.CutoffInProgress);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.CVRCheckFailure, ResponseCode.CVRCheckFailure);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.CVRConfigurationError, ResponseCode.CVRConfigurationError);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.DoNotHonor, ResponseCode.DoNotHonor);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.DuplicateRecord, ResponseCode.DuplicateRecord);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.DuplicateTransaction, ResponseCode.DuplicateTransaction);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.Error, ResponseCode.Error);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ExceedsCashLimit, ResponseCode.ExceedsCashLimit);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ExceedsWithdrawalFrequency, ResponseCode.ExceedsWithdrawalFrequency);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ExceedsWithdrawalLimit, ResponseCode.ExceedsWithdrawalLimit);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ExpiredCard, ResponseCode.ExpiredCard);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ExpiredCardPickUp, ResponseCode.ExpiredCardPickUp);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.FileUpdateFailed, ResponseCode.FileUpdateFailed);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.FileUpdateFieldEditError, ResponseCode.FileUpdateFieldEditError);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.FileUpdateLocked, ResponseCode.FileUpdateLocked);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.FileUpdateNotSupported, ResponseCode.FileUpdateNotSupported);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.FormatError, ResponseCode.FormatError);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.FunctionNotSupported, ResponseCode.FunctionNotSupported);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.HardCapture, ResponseCode.HardCapture);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.HonorWithIdentification, ResponseCode.HonorWithIdentification);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.IdentificationCrossCheckRequired, ResponseCode.IdentificationCrossCheckRequired);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.IdentificationRequired, ResponseCode.IdentificationRequired);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.IncorrectPIN, ResponseCode.IncorrectPIN);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.InsufficientFunds, ResponseCode.InsufficientFunds);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.InterveneBankApprovalRequired, ResponseCode.InterveneBankApprovalRequired);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.InterveneBankApprovalRequiredForPartialAmount, ResponseCode.InterveneBankApprovalRequiredForPartialAmount);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.InvalidAmount, ResponseCode.InvalidAmount);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.InvalidCardNumber, ResponseCode.InvalidCardNumber);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.InvalidMerchant, ResponseCode.InvalidMerchant);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.InvalidResponse, ResponseCode.InvalidResponse);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.InvalidTransaction, ResponseCode.InvalidTransaction);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.IssuerOrSwitchInoperative, ResponseCode.IssuerOrSwitchInoperative);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.LostCardPickUp, ResponseCode.LostCardPickUp);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.MACError, ResponseCode.MACError);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.NoActionTaken, ResponseCode.NoActionTaken);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.NoCardRecord, ResponseCode.NoCardRecord);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.NoCheckAccount, ResponseCode.NoCheckAccount);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.NoCreditAccount, ResponseCode.NoCreditAccount);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.NoInvestmentAccount, ResponseCode.NoInvestmentAccount);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.NoSavingsAccount, ResponseCode.NoSavingsAccount);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.NoSuchIssuer, ResponseCode.NoSuchIssuer);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.NoUniversalAccount, ResponseCode.NoUniversalAccount);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.OriginalAmountIncorrect, ResponseCode.OriginalAmountIncorrect);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.PickupCard, ResponseCode.PickupCard);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.PickUpSpecialCondition, ResponseCode.PickUpSpecialCondition);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.PINChangeFailed, ResponseCode.PINChangeFailed);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.PINTriesExceeded, ResponseCode.PINTriesExceeded);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.PINTriesExceededPickUp, ResponseCode.PINTriesExceededPickUp);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.PINUnblockFailed, ResponseCode.PINUnblockFailed);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.PrepayError, ResponseCode.PrepayError);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ReconcileError, ResponseCode.ReconcileError);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ReenterTransaction, ResponseCode.ReenterTransaction);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ReferToCardIssuer, ResponseCode.ReferToCardIssuer);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ReferToCardIssuerSpecialCondition, ResponseCode.ReferToCardIssuerSpecialCondition);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.RequestInProgress, ResponseCode.RequestInProgress);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ResponseReceivedTooLate, ResponseCode.ResponseReceivedTooLate);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.RestrictedCard, ResponseCode.RestrictedCard);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.RestrictedCardPickUp, ResponseCode.RestrictedCardPickUp);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.RoutingError, ResponseCode.RoutingError);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.SecurityViolation, ResponseCode.SecurityViolation);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.StolenCardPickUp, ResponseCode.StolenCardPickUp);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.SuspectedFraud, ResponseCode.SuspectedFraud);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.SuspectedFraudPickUp, ResponseCode.SuspectedFraudPickUp);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.SuspectedMalfunction, ResponseCode.SuspectedMalfunction);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.SystemMalfunction, ResponseCode.SystemMalfunction);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.TransactionNotPermittedToCardholder, ResponseCode.TransactionNotPermittedToCardholder);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.TransactionNotPermittedToTerminal, ResponseCode.TransactionNotPermittedToTerminal);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.TVRCheckFailure, ResponseCode.TVRCheckFailure);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.TVRConfigurationError, ResponseCode.TVRConfigurationError);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.UnableToLocateRecord, ResponseCode.UnableToLocateRecord);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.UnacceptablePIN, ResponseCode.UnacceptablePIN);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.UnacceptableTransactionFee, ResponseCode.UnacceptableTransactionFee);
			EFTProperties<ResponseCodeEnum>.Add(ResponseCodeEnum.ViolationOfLaw, ResponseCode.ViolationOfLaw);
		}
	}
}
