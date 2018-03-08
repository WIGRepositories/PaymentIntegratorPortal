using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class ExtendedTransactionType : EFTProperties<ExtendedTransactionTypeEnum>
	{
		public static EFTConstant<string> MembershipSignup;

		public static EFTConstant<string> BillsRetracted;

		public static EFTConstant<string> IOUDispense;

		public static EFTConstant<string> CashAccepted;

		public static EFTConstant<string> Rounding;

		public static EFTConstant<string> FeeReversal;

		public static EFTConstant<string> ChangeDispenseFromCashAcceptor;

		public static EFTConstant<string> ChangeDispenseFromCanister;

		public static EFTConstant<string> DepositEnvelopeDispense;

		public static EFTConstant<string> DepositWithUnknownAmount;

		public static EFTConstant<string> RKDPublicKeyRequestSignature;

		public static EFTConstant<string> RKDMasterKeyRequestSignature;

		public static EFTConstant<string> RKDMasterKeyVerificationSignature;

		public static EFTConstant<string> RKDPublicKeyRequestCertificate;

		public static EFTConstant<string> RKDMasterKeyRequestCertificate;

		public static EFTConstant<string> RKDMasterKeyVerificationCertificate;

		public static EFTConstant<string> RKDMasterKeyExchange;

		public static EFTConstant<string> RKDPublicKeyExchange;

		public static EFTConstant<string> RKDMasterKeyUpdate;

		public static EFTConstant<string> CashReplenishment;

		public static EFTConstant<string> DepositorCleanout;

		public static EFTConstant<string> CashReplenishmentAndDepositorCleanout;

		public static EFTConstant<string> SuspectTransactionBankSaved;

		public static EFTConstant<string> SuspectTransactionBankNotSaved;

		public static EFTConstant<string> MediaTotalsPrinted;

		public static EFTConstant<string> MediaTotalsCleared;

		public static EFTConstant<string> SuspectTransctionNoActionTaken;

		public static EFTConstant<string> DeclinedTransactionTerminalProblem;

		public static EFTConstant<string> UnblockPIN;

		public static EFTConstant<string> PINChangeFailure;

		public static EFTConstant<string> PINUnblockFailure;

		public static EFTConstant<string> EMVCryptogramValidation;

		public static EFTConstant<string> EMVTransactionResult;

		public static EFTConstant<string> SignatureCapture;

		public static EFTConstant<string> CardActivation;

		public static EFTConstant<string> CardDeactivation;

		public static EFTConstant<string> StatementOrder;

		public static EFTConstant<string> CheckBookOrder;

		public static EFTConstant<string> StopCheck;

		public static EFTConstant<string> CustomerUpdate;

		public static EFTConstant<string> AccountUpdate;

		public static EFTConstant<string> CardUpdate;

		public static EFTConstant<string> FraudAlert;

		public static EFTConstant<string> SuspectTranasction;

		public static EFTConstant<string> TransactionDocumentationRetrievalRequest;

		public static EFTConstant<string> Chargeback;

		public static EFTConstant<string> ChargebackReversal;

		public static EFTConstant<string> Representment;

		public static EFTConstant<string> ArbitrationChargeback;

		public static EFTConstant<string> FeeCollection;

		public static EFTConstant<string> FundsDisbursement;

		public static EFTConstant<string> AdministrationTextMessage;

		public static EFTConstant<string> MoneyOrder;

		public static EFTConstant<string> MoneyTransfer;

		public static EFTConstant<string> MoneyTransferInquiry;

		public static EFTConstant<string> CheckCashInquiry;

		public static EFTConstant<string> DebitOrder;

		public static EFTConstant<string> DebitOrderInquiry;

		public static EFTConstant<string> FutureDebitOrdersInquiry;

		public static EFTConstant<string> CheckDepositWithOCREntry;

		public static EFTConstant<string> CheckDepositWithManualEntry;

		public static EFTConstant<string> CheckDepositWithOCREntryCashBackToFollow;

		public static EFTConstant<string> CheckDepositWithManualEntryCashBackToFollow;

		public static EFTConstant<string> CashDepositWithBunchNoteAcceptor;

		public static EFTConstant<string> OfflineFundsLoad;

		public static EFTConstant<string> OfflineFundsUnload;

		public static EFTConstant<string> OfflineFundsAccountSynchronization;

		public static EFTConstant<string> NonUsageFee;

		public static EFTConstant<string> FundingAccountCredit;

		public static EFTConstant<string> LoanActivation;

		public static EFTConstant<string> LoanCancellation;

		public static EFTConstant<string> Prepay;

		public static EFTConstant<string> PrepayAnonymousVoucher;

		public static EFTConstant<string> PrepayConsumerSpecificVoucher;

		public static EFTConstant<string> PrepayElectronicTopup;

		public static EFTConstant<string> PrepayAnonymousVoucherReprint;

		public static EFTConstant<string> CardActivationWithDepositVerifiedByOperator;

		public static EFTConstant<string> DepositVerifiedByOperator;

		public static EFTConstant<string> CardDeactivationWithCashBack;

		public static EFTConstant<string> CheckGuaranteeForGoodsAndServicesWithCashback;

		public static EFTConstant<string> CheckVerificationForGoodsAndServicesWithCashBack;

		public static EFTConstant<string> CurrencyConversionLookupInquiry;

		public static EFTConstant<string> CustomerVerificationInquiry;

		public static EFTConstant<string> CustomerLinkedAccountInquiry;

		public static EFTConstant<string> CustomerLinkedCardInquiry;

		public static EFTConstant<string> CustomerInquiry;

		public static EFTConstant<string> CardLinkedAccountInquiry;

		public static EFTConstant<string> CardInquiry;

		public static EFTConstant<string> AccountLinkedCustomerInquiry;

		public static EFTConstant<string> AccountInquiry;

		static ExtendedTransactionType()
		{
			ExtendedTransactionType.MembershipSignup = new EFTConstant<string>("1000");
			ExtendedTransactionType.BillsRetracted = new EFTConstant<string>("1001");
			ExtendedTransactionType.IOUDispense = new EFTConstant<string>("1002");
			ExtendedTransactionType.CashAccepted = new EFTConstant<string>("1003");
			ExtendedTransactionType.Rounding = new EFTConstant<string>("1004");
			ExtendedTransactionType.FeeReversal = new EFTConstant<string>("1005");
			ExtendedTransactionType.ChangeDispenseFromCashAcceptor = new EFTConstant<string>("1006");
			ExtendedTransactionType.ChangeDispenseFromCanister = new EFTConstant<string>("1007");
			ExtendedTransactionType.DepositEnvelopeDispense = new EFTConstant<string>("1008");
			ExtendedTransactionType.DepositWithUnknownAmount = new EFTConstant<string>("1009");
			ExtendedTransactionType.RKDPublicKeyRequestSignature = new EFTConstant<string>("1160");
			ExtendedTransactionType.RKDMasterKeyRequestSignature = new EFTConstant<string>("1161");
			ExtendedTransactionType.RKDMasterKeyVerificationSignature = new EFTConstant<string>("1162");
			ExtendedTransactionType.RKDPublicKeyRequestCertificate = new EFTConstant<string>("1170");
			ExtendedTransactionType.RKDMasterKeyRequestCertificate = new EFTConstant<string>("1171");
			ExtendedTransactionType.RKDMasterKeyVerificationCertificate = new EFTConstant<string>("1172");
			ExtendedTransactionType.RKDMasterKeyExchange = new EFTConstant<string>("1180");
			ExtendedTransactionType.RKDPublicKeyExchange = new EFTConstant<string>("1181");
			ExtendedTransactionType.RKDMasterKeyUpdate = new EFTConstant<string>("1182");
			ExtendedTransactionType.CashReplenishment = new EFTConstant<string>("2000");
			ExtendedTransactionType.DepositorCleanout = new EFTConstant<string>("2001");
			ExtendedTransactionType.CashReplenishmentAndDepositorCleanout = new EFTConstant<string>("2002");
			ExtendedTransactionType.SuspectTransactionBankSaved = new EFTConstant<string>("2003");
			ExtendedTransactionType.SuspectTransactionBankNotSaved = new EFTConstant<string>("2004");
			ExtendedTransactionType.MediaTotalsPrinted = new EFTConstant<string>("2005");
			ExtendedTransactionType.MediaTotalsCleared = new EFTConstant<string>("2006");
			ExtendedTransactionType.SuspectTransctionNoActionTaken = new EFTConstant<string>("2007");
			ExtendedTransactionType.DeclinedTransactionTerminalProblem = new EFTConstant<string>("2008");
			ExtendedTransactionType.UnblockPIN = new EFTConstant<string>("3000");
			ExtendedTransactionType.PINChangeFailure = new EFTConstant<string>("3001");
			ExtendedTransactionType.PINUnblockFailure = new EFTConstant<string>("3002");
			ExtendedTransactionType.EMVCryptogramValidation = new EFTConstant<string>("3010");
			ExtendedTransactionType.EMVTransactionResult = new EFTConstant<string>("3011");
			ExtendedTransactionType.SignatureCapture = new EFTConstant<string>("3030");
			ExtendedTransactionType.CardActivation = new EFTConstant<string>("3100");
			ExtendedTransactionType.CardDeactivation = new EFTConstant<string>("3101");
			ExtendedTransactionType.StatementOrder = new EFTConstant<string>("3200");
			ExtendedTransactionType.CheckBookOrder = new EFTConstant<string>("3201");
			ExtendedTransactionType.StopCheck = new EFTConstant<string>("3202");
			ExtendedTransactionType.CustomerUpdate = new EFTConstant<string>("3300");
			ExtendedTransactionType.AccountUpdate = new EFTConstant<string>("3301");
			ExtendedTransactionType.CardUpdate = new EFTConstant<string>("3302");
			ExtendedTransactionType.FraudAlert = new EFTConstant<string>("4000");
			ExtendedTransactionType.SuspectTranasction = new EFTConstant<string>("4001");
			ExtendedTransactionType.TransactionDocumentationRetrievalRequest = new EFTConstant<string>("4100");
			ExtendedTransactionType.Chargeback = new EFTConstant<string>("4101");
			ExtendedTransactionType.ChargebackReversal = new EFTConstant<string>("4102");
			ExtendedTransactionType.Representment = new EFTConstant<string>("4103");
			ExtendedTransactionType.ArbitrationChargeback = new EFTConstant<string>("4104");
			ExtendedTransactionType.FeeCollection = new EFTConstant<string>("4105");
			ExtendedTransactionType.FundsDisbursement = new EFTConstant<string>("4106");
			ExtendedTransactionType.AdministrationTextMessage = new EFTConstant<string>("4107");
			ExtendedTransactionType.MoneyOrder = new EFTConstant<string>("6000");
			ExtendedTransactionType.MoneyTransfer = new EFTConstant<string>("6001");
			ExtendedTransactionType.MoneyTransferInquiry = new EFTConstant<string>("6002");
			ExtendedTransactionType.CheckCashInquiry = new EFTConstant<string>("6003");
			ExtendedTransactionType.DebitOrder = new EFTConstant<string>("6010");
			ExtendedTransactionType.DebitOrderInquiry = new EFTConstant<string>("6011");
			ExtendedTransactionType.FutureDebitOrdersInquiry = new EFTConstant<string>("6012");
			ExtendedTransactionType.CheckDepositWithOCREntry = new EFTConstant<string>("6100");
			ExtendedTransactionType.CheckDepositWithManualEntry = new EFTConstant<string>("6101");
			ExtendedTransactionType.CheckDepositWithOCREntryCashBackToFollow = new EFTConstant<string>("6102");
			ExtendedTransactionType.CheckDepositWithManualEntryCashBackToFollow = new EFTConstant<string>("6103");
			ExtendedTransactionType.CashDepositWithBunchNoteAcceptor = new EFTConstant<string>("6110");
			ExtendedTransactionType.OfflineFundsLoad = new EFTConstant<string>("6200");
			ExtendedTransactionType.OfflineFundsUnload = new EFTConstant<string>("6201");
			ExtendedTransactionType.OfflineFundsAccountSynchronization = new EFTConstant<string>("6202");
			ExtendedTransactionType.NonUsageFee = new EFTConstant<string>("6203");
			ExtendedTransactionType.FundingAccountCredit = new EFTConstant<string>("6204");
			ExtendedTransactionType.LoanActivation = new EFTConstant<string>("6300");
			ExtendedTransactionType.LoanCancellation = new EFTConstant<string>("6301");
			ExtendedTransactionType.Prepay = new EFTConstant<string>("6400");
			ExtendedTransactionType.PrepayAnonymousVoucher = new EFTConstant<string>("6401");
			ExtendedTransactionType.PrepayConsumerSpecificVoucher = new EFTConstant<string>("6402");
			ExtendedTransactionType.PrepayElectronicTopup = new EFTConstant<string>("6403");
			ExtendedTransactionType.PrepayAnonymousVoucherReprint = new EFTConstant<string>("6404");
			ExtendedTransactionType.CardActivationWithDepositVerifiedByOperator = new EFTConstant<string>("6500");
			ExtendedTransactionType.DepositVerifiedByOperator = new EFTConstant<string>("6501");
			ExtendedTransactionType.CardDeactivationWithCashBack = new EFTConstant<string>("6502");
			ExtendedTransactionType.CheckGuaranteeForGoodsAndServicesWithCashback = new EFTConstant<string>("6600");
			ExtendedTransactionType.CheckVerificationForGoodsAndServicesWithCashBack = new EFTConstant<string>("6601");
			ExtendedTransactionType.CurrencyConversionLookupInquiry = new EFTConstant<string>("6700");
			ExtendedTransactionType.CustomerVerificationInquiry = new EFTConstant<string>("7000");
			ExtendedTransactionType.CustomerLinkedAccountInquiry = new EFTConstant<string>("7001");
			ExtendedTransactionType.CustomerLinkedCardInquiry = new EFTConstant<string>("7002");
			ExtendedTransactionType.CustomerInquiry = new EFTConstant<string>("7003");
			ExtendedTransactionType.CardLinkedAccountInquiry = new EFTConstant<string>("7004");
			ExtendedTransactionType.CardInquiry = new EFTConstant<string>("7005");
			ExtendedTransactionType.AccountLinkedCustomerInquiry = new EFTConstant<string>("7006");
			ExtendedTransactionType.AccountInquiry = new EFTConstant<string>("7007");
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.AccountInquiry, ExtendedTransactionType.AccountInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.AccountLinkedCustomerInquiry, ExtendedTransactionType.AccountLinkedCustomerInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.AccountUpdate, ExtendedTransactionType.AccountUpdate);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.AdministrationTextMessage, ExtendedTransactionType.AdministrationTextMessage);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.ArbitrationChargeback, ExtendedTransactionType.ArbitrationChargeback);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.BillsRetracted, ExtendedTransactionType.BillsRetracted);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CardActivation, ExtendedTransactionType.CardActivation);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CardActivationWithDepositVerifiedByOperator, ExtendedTransactionType.CardActivationWithDepositVerifiedByOperator);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CardDeactivation, ExtendedTransactionType.CardDeactivation);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CardDeactivationWithCashBack, ExtendedTransactionType.CardDeactivationWithCashBack);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CardInquiry, ExtendedTransactionType.CardInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CardLinkedAccountInquiry, ExtendedTransactionType.CardLinkedAccountInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CardUpdate, ExtendedTransactionType.CardUpdate);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CashAccepted, ExtendedTransactionType.CashAccepted);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CashDepositWithBunchNoteAcceptor, ExtendedTransactionType.CashDepositWithBunchNoteAcceptor);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CashReplenishment, ExtendedTransactionType.CashReplenishment);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CashReplenishmentAndDepositorCleanout, ExtendedTransactionType.CashReplenishmentAndDepositorCleanout);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.ChangeDispenseFromCanister, ExtendedTransactionType.ChangeDispenseFromCanister);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.ChangeDispenseFromCashAcceptor, ExtendedTransactionType.ChangeDispenseFromCashAcceptor);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.Chargeback, ExtendedTransactionType.Chargeback);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.ChargebackReversal, ExtendedTransactionType.ChargebackReversal);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CheckBookOrder, ExtendedTransactionType.CheckBookOrder);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CheckCashInquiry, ExtendedTransactionType.CheckCashInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CheckDepositWithManualEntry, ExtendedTransactionType.CheckDepositWithManualEntry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CheckDepositWithManualEntryCashBackToFollow, ExtendedTransactionType.CheckDepositWithManualEntryCashBackToFollow);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CheckDepositWithOCREntry, ExtendedTransactionType.CheckDepositWithOCREntry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CheckDepositWithOCREntryCashBackToFollow, ExtendedTransactionType.CheckDepositWithOCREntryCashBackToFollow);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CheckGuaranteeForGoodsAndServicesWithCashback, ExtendedTransactionType.CheckGuaranteeForGoodsAndServicesWithCashback);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CheckVerificationForGoodsAndServicesWithCashBack, ExtendedTransactionType.CheckVerificationForGoodsAndServicesWithCashBack);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CurrencyConversionLookupInquiry, ExtendedTransactionType.CurrencyConversionLookupInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CustomerInquiry, ExtendedTransactionType.CustomerInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CustomerLinkedAccountInquiry, ExtendedTransactionType.CustomerLinkedAccountInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CustomerLinkedCardInquiry, ExtendedTransactionType.CustomerLinkedCardInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CustomerUpdate, ExtendedTransactionType.CustomerUpdate);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.CustomerVerificationInquiry, ExtendedTransactionType.CustomerVerificationInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.DebitOrder, ExtendedTransactionType.DebitOrder);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.DebitOrderInquiry, ExtendedTransactionType.DebitOrderInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.DeclinedTransactionTerminalProblem, ExtendedTransactionType.DeclinedTransactionTerminalProblem);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.DepositEnvelopeDispense, ExtendedTransactionType.DepositEnvelopeDispense);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.DepositorCleanout, ExtendedTransactionType.DepositorCleanout);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.DepositVerifiedByOperator, ExtendedTransactionType.DepositVerifiedByOperator);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.DepositWithUnknownAmount, ExtendedTransactionType.DepositWithUnknownAmount);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.EMVCryptogramValidation, ExtendedTransactionType.EMVCryptogramValidation);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.EMVTransactionResult, ExtendedTransactionType.EMVTransactionResult);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.FeeCollection, ExtendedTransactionType.FeeCollection);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.FeeReversal, ExtendedTransactionType.FeeReversal);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.FraudAlert, ExtendedTransactionType.FraudAlert);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.FundingAccountCredit, ExtendedTransactionType.FundingAccountCredit);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.FundsDisbursement, ExtendedTransactionType.FundsDisbursement);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.FutureDebitOrdersInquiry, ExtendedTransactionType.FutureDebitOrdersInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.IOUDispense, ExtendedTransactionType.IOUDispense);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.LoanActivation, ExtendedTransactionType.LoanActivation);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.LoanCancellation, ExtendedTransactionType.LoanCancellation);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.MediaTotalsCleared, ExtendedTransactionType.MediaTotalsCleared);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.MediaTotalsPrinted, ExtendedTransactionType.MediaTotalsPrinted);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.MembershipSignup, ExtendedTransactionType.MembershipSignup);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.MoneyOrder, ExtendedTransactionType.MoneyOrder);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.MoneyTransfer, ExtendedTransactionType.MoneyTransfer);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.MoneyTransferInquiry, ExtendedTransactionType.MoneyTransferInquiry);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.NonUsageFee, ExtendedTransactionType.NonUsageFee);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.OfflineFundsAccountSynchronization, ExtendedTransactionType.OfflineFundsAccountSynchronization);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.OfflineFundsLoad, ExtendedTransactionType.OfflineFundsLoad);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.OfflineFundsUnload, ExtendedTransactionType.OfflineFundsUnload);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.PINChangeFailure, ExtendedTransactionType.PINChangeFailure);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.PINUnblockFailure, ExtendedTransactionType.PINUnblockFailure);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.Prepay, ExtendedTransactionType.Prepay);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.PrepayAnonymousVoucher, ExtendedTransactionType.PrepayAnonymousVoucher);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.PrepayAnonymousVoucherReprint, ExtendedTransactionType.PrepayAnonymousVoucherReprint);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.PrepayConsumerSpecificVoucher, ExtendedTransactionType.PrepayConsumerSpecificVoucher);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.PrepayElectronicTopup, ExtendedTransactionType.PrepayElectronicTopup);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.Representment, ExtendedTransactionType.Representment);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.RKDMasterKeyExchange, ExtendedTransactionType.RKDMasterKeyExchange);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.RKDMasterKeyRequestCertificate, ExtendedTransactionType.RKDMasterKeyRequestCertificate);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.RKDMasterKeyRequestSignature, ExtendedTransactionType.RKDMasterKeyRequestSignature);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.RKDMasterKeyUpdate, ExtendedTransactionType.RKDMasterKeyUpdate);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.RKDMasterKeyVerificationCertificate, ExtendedTransactionType.RKDMasterKeyVerificationCertificate);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.RKDMasterKeyVerificationSignature, ExtendedTransactionType.RKDMasterKeyVerificationSignature);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.RKDPublicKeyExchange, ExtendedTransactionType.RKDPublicKeyExchange);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.RKDPublicKeyRequestCertificate, ExtendedTransactionType.RKDPublicKeyRequestCertificate);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.RKDPublicKeyRequestSignature, ExtendedTransactionType.RKDPublicKeyRequestSignature);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.Rounding, ExtendedTransactionType.Rounding);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.SignatureCapture, ExtendedTransactionType.SignatureCapture);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.StatementOrder, ExtendedTransactionType.StatementOrder);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.StopCheck, ExtendedTransactionType.StopCheck);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.SuspectTranasction, ExtendedTransactionType.SuspectTranasction);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.SuspectTransactionBankNotSaved, ExtendedTransactionType.SuspectTransactionBankNotSaved);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.SuspectTransasctionBankSaved, ExtendedTransactionType.SuspectTransactionBankSaved);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.SuspectTransctionNoActionTaken, ExtendedTransactionType.SuspectTransctionNoActionTaken);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.TransactionDocumentationRetrievalRequest, ExtendedTransactionType.TransactionDocumentationRetrievalRequest);
			EFTProperties<ExtendedTransactionTypeEnum>.Add(ExtendedTransactionTypeEnum.UnblockPIN, ExtendedTransactionType.UnblockPIN);
		}
	}
}
