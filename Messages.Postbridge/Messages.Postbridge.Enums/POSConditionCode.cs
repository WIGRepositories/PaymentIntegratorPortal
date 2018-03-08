using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class POSConditionCode : EFTProperties<POSConditionCodeEnum>
	{
		public static EFTConstant<string> NormalPresentment;

		public static EFTConstant<string> CustomerNotPresent;

		public static EFTConstant<string> UnattendedTerminalCardCanBeRetained;

		public static EFTConstant<string> MerchantSuspicious;

		public static EFTConstant<string> ElectronicCashRegister;

		public static EFTConstant<string> CustomerPresentCardNotPresent;

		public static EFTConstant<string> PreauthorizedRequest;

		public static EFTConstant<string> TelephoneDeviceRequired;

		public static EFTConstant<string> MailOrderTelephoneOrder;

		public static EFTConstant<string> POSSecurityAlert;

		public static EFTConstant<string> CustomerIdentityVerified;

		public static EFTConstant<string> SuspectedFraud;

		public static EFTConstant<string> SecurityReasons;

		public static EFTConstant<string> RepresentationOfItem;

		public static EFTConstant<string> PublicUtilityTerminal;

		public static EFTConstant<string> CustomerTerminal;

		public static EFTConstant<string> AdministrativeTerminal;

		public static EFTConstant<string> ReturnedItem;

		public static EFTConstant<string> NoCheckInEnvelopeReturn;

		public static EFTConstant<string> DepositOutOfBalanceReturn;

		public static EFTConstant<string> PaymentOutOfBalanceReturn;

		public static EFTConstant<string> ManualReversal;

		public static EFTConstant<string> TerminalErrorCounted;

		public static EFTConstant<string> TerminalErrorNotCounted;

		public static EFTConstant<string> DepositOutOfBalance;

		public static EFTConstant<string> PaymentOutOfBalance;

		public static EFTConstant<string> WithdrawalErrorReversed;

		public static EFTConstant<string> UnattendedTerminalCardCannotBeRetained;

		public static EFTConstant<string> PartialReversalAllowed;

		static POSConditionCode()
		{
			POSConditionCode.NormalPresentment = new EFTConstant<string>("00");
			POSConditionCode.CustomerNotPresent = new EFTConstant<string>("01");
			POSConditionCode.UnattendedTerminalCardCanBeRetained = new EFTConstant<string>("02");
			POSConditionCode.MerchantSuspicious = new EFTConstant<string>("03");
			POSConditionCode.ElectronicCashRegister = new EFTConstant<string>("04");
			POSConditionCode.CustomerPresentCardNotPresent = new EFTConstant<string>("05");
			POSConditionCode.PreauthorizedRequest = new EFTConstant<string>("06");
			POSConditionCode.TelephoneDeviceRequired = new EFTConstant<string>("07");
			POSConditionCode.MailOrderTelephoneOrder = new EFTConstant<string>("08");
			POSConditionCode.POSSecurityAlert = new EFTConstant<string>("09");
			POSConditionCode.CustomerIdentityVerified = new EFTConstant<string>("10");
			POSConditionCode.SuspectedFraud = new EFTConstant<string>("11");
			POSConditionCode.SecurityReasons = new EFTConstant<string>("12");
			POSConditionCode.RepresentationOfItem = new EFTConstant<string>("13");
			POSConditionCode.PublicUtilityTerminal = new EFTConstant<string>("14");
			POSConditionCode.CustomerTerminal = new EFTConstant<string>("15");
			POSConditionCode.AdministrativeTerminal = new EFTConstant<string>("16");
			POSConditionCode.ReturnedItem = new EFTConstant<string>("17");
			POSConditionCode.NoCheckInEnvelopeReturn = new EFTConstant<string>("18");
			POSConditionCode.DepositOutOfBalanceReturn = new EFTConstant<string>("19");
			POSConditionCode.PaymentOutOfBalanceReturn = new EFTConstant<string>("20");
			POSConditionCode.ManualReversal = new EFTConstant<string>("21");
			POSConditionCode.TerminalErrorCounted = new EFTConstant<string>("22");
			POSConditionCode.TerminalErrorNotCounted = new EFTConstant<string>("23");
			POSConditionCode.DepositOutOfBalance = new EFTConstant<string>("24");
			POSConditionCode.PaymentOutOfBalance = new EFTConstant<string>("25");
			POSConditionCode.WithdrawalErrorReversed = new EFTConstant<string>("26");
			POSConditionCode.UnattendedTerminalCardCannotBeRetained = new EFTConstant<string>("27");
			POSConditionCode.PartialReversalAllowed = new EFTConstant<string>("41");
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.AdministrativeTerminal, POSConditionCode.AdministrativeTerminal);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.CustomerIdentityVerified, POSConditionCode.CustomerIdentityVerified);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.CustomerNotPresent, POSConditionCode.CustomerNotPresent);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.CustomerPresentCardNotPresent, POSConditionCode.CustomerPresentCardNotPresent);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.CustomerTerminal, POSConditionCode.CustomerTerminal);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.DepositOutOfBalance, POSConditionCode.DepositOutOfBalance);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.DepositOutOfBalanceReturn, POSConditionCode.DepositOutOfBalanceReturn);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.ElectronicCashRegister, POSConditionCode.ElectronicCashRegister);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.MailOrderTelephoneOrder, POSConditionCode.MailOrderTelephoneOrder);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.ManualReversal, POSConditionCode.ManualReversal);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.MerchantSuspicious, POSConditionCode.MerchantSuspicious);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.NoCheckInEnvelopeReturn, POSConditionCode.NoCheckInEnvelopeReturn);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.NormalPresentment, POSConditionCode.NormalPresentment);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.PartialReversalAllowed, POSConditionCode.PartialReversalAllowed);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.PaymentOutOfBalance, POSConditionCode.PaymentOutOfBalance);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.PaymentOutOfBalanceReturn, POSConditionCode.PaymentOutOfBalanceReturn);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.POSSecurityAlert, POSConditionCode.POSSecurityAlert);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.PreauthorizedRequest, POSConditionCode.PreauthorizedRequest);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.PublicUtilityTerminal, POSConditionCode.PublicUtilityTerminal);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.RepresentationOfItem, POSConditionCode.RepresentationOfItem);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.ReturnedItem, POSConditionCode.ReturnedItem);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.SecurityReasons, POSConditionCode.SecurityReasons);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.SuspectedFraud, POSConditionCode.SuspectedFraud);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.TelephoneDeviceRequired, POSConditionCode.TelephoneDeviceRequired);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.TerminalErrorCounted, POSConditionCode.TerminalErrorCounted);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.TerminalErrorNotCounted, POSConditionCode.TerminalErrorNotCounted);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.UnattendedTerminalCardCanBeRetained, POSConditionCode.UnattendedTerminalCardCanBeRetained);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.UnattendedTerminalCardCannotBeRetained, POSConditionCode.UnattendedTerminalCardCannotBeRetained);
			EFTProperties<POSConditionCodeEnum>.Add(POSConditionCodeEnum.WithdrawalErrorReversed, POSConditionCode.WithdrawalErrorReversed);
		}
	}
}
