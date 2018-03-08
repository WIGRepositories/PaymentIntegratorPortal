using System;

namespace Messages.Postbridge.Enums
{
	public enum POSConditionCodeEnum
	{
		NormalPresentment,
		CustomerNotPresent,
		UnattendedTerminalCardCanBeRetained,
		MerchantSuspicious,
		ElectronicCashRegister,
		CustomerPresentCardNotPresent,
		PreauthorizedRequest,
		TelephoneDeviceRequired,
		MailOrderTelephoneOrder,
		POSSecurityAlert,
		CustomerIdentityVerified,
		SuspectedFraud,
		SecurityReasons,
		RepresentationOfItem,
		PublicUtilityTerminal,
		CustomerTerminal,
		AdministrativeTerminal,
		ReturnedItem,
		NoCheckInEnvelopeReturn,
		DepositOutOfBalanceReturn,
		PaymentOutOfBalanceReturn,
		ManualReversal,
		TerminalErrorCounted,
		TerminalErrorNotCounted,
		DepositOutOfBalance,
		PaymentOutOfBalance,
		WithdrawalErrorReversed,
		UnattendedTerminalCardCannotBeRetained,
		PartialReversalAllowed
	}
}
