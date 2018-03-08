using System;

namespace Messages.Postbridge
{
	public enum PrivateFields
	{
		SwitchKey = 2,
		RoutingInformation,
		POSData,
		ServiceStationData,
		AuthorizationProfile,
		CheckData,
		RetentionData,
		AdditionalNodeData,
		CVV2,
		OriginalKey,
		TerminalOwner,
		POSGeographicData,
		SponsorBank,
		AddressVerificationData,
		AddressVerificationResult,
		CardholderInformation,
		ValidationData,
		BankDetails,
		OriginatorAuthorizerDateSettlement,
		RecordID,
		StructuredData,
		PayeeNameAndAddress,
		PayerAccount,
		ICCData,
		OriginalNode,
		CardVerificationResult,
		AMEXCID,
		ThreeDSecureData,
		ThreeDSecureResult,
		IssuerNetworkID,
		UCAFData,
		ExtendedTransactionType,
		AccountTypeQualifiers,
		AcquirerNetworkID,
		OriginalResponseCode = 39,
		TransactionReference
	}
}
