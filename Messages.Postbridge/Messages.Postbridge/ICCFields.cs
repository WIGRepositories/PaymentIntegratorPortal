using System;

namespace Messages.Postbridge
{
	public enum ICCFields
	{
		AmountAuthorized = 2,
		AmountOther,
		ApplicationIdentifier,
		ApplicationInterchangeProfile,
		ApplicationTransactionCounter,
		ApplicationUsageControl,
		AuthorizationResponseCode,
		CardAuthenticationReliabilityIndicator,
		CardAuthenticationResultsCode,
		ChipConditionCode,
		Cryptogram,
		CryptogramInformationData,
		CVMList,
		CVMResults,
		InterfaceDeviceSerialNumber,
		IssuerActionCode,
		IssuerApplicationData,
		IssuerScriptResults,
		TerminalApplicationVersionNumber,
		TerminalCapabilities,
		TerminalCountryCode,
		TerminalType,
		TerminalVerificationResult,
		TransactionCategoryCode,
		TransactionCurrencyCode,
		TransactionDate,
		TransactionSequenceCounter,
		TransactionType,
		UnpredictableNumber
	}
}
