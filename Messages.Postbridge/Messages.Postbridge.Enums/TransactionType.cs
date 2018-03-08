using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class TransactionType : EFTProperties<TransactionTypeEnum>
	{
		public static EFTConstant<string> GoodsAndServices;

		public static EFTConstant<string> CashWithdrawal;

		public static EFTConstant<string> DebitAdjustment;

		public static EFTConstant<string> CheckCash;

		public static EFTConstant<string> CheckVerification;

		public static EFTConstant<string> EuroCheque;

		public static EFTConstant<string> TravellersCheck;

		public static EFTConstant<string> LetterOfCredit;

		public static EFTConstant<string> Giro;

		public static EFTConstant<string> GoodsAndServicesWithCashback;

		public static EFTConstant<string> WireTransfer;

		public static EFTConstant<string> QuasiCash;

		public static EFTConstant<string> GeneralDebit;

		public static EFTConstant<string> VisaCashLoadSettlementReversal;

		public static EFTConstant<string> ReturnRefund;

		public static EFTConstant<string> Deposit;

		public static EFTConstant<string> CreditAdjustment;

		public static EFTConstant<string> CheckDepositGuarantee;

		public static EFTConstant<string> CheckDeposit;

		public static EFTConstant<string> GeneralCredit;

		public static EFTConstant<string> MerchandiseRequest;

		public static EFTConstant<string> VisaCashLoadSettlement;

		public static EFTConstant<string> AvailableBalanceInquiry;

		public static EFTConstant<string> BalanceInquiry;

		public static EFTConstant<string> GeneralInquiry;

		public static EFTConstant<string> FullStatementInquiry;

		public static EFTConstant<string> MerchandiseInquiry;

		public static EFTConstant<string> CardVerificationInquiry;

		public static EFTConstant<string> MiniStatementInquiry;

		public static EFTConstant<string> LinkedAccountInquiry;

		public static EFTConstant<string> CardholderAccountsTransfer;

		public static EFTConstant<string> GeneralTransfer;

		public static EFTConstant<string> PaymentFromAccount;

		public static EFTConstant<string> PaymentByDeposit;

		public static EFTConstant<string> GeneralPayment;

		public static EFTConstant<string> PaymentToAccount;

		public static EFTConstant<string> PaymentFromAccountToAccount;

		public static EFTConstant<string> PlaceHoldOnCard;

		public static EFTConstant<string> GeneralAdmin;

		public static EFTConstant<string> ChangePIN;

		public static EFTConstant<string> DeadEnd;

		static TransactionType()
		{
			TransactionType.GoodsAndServices = new EFTConstant<string>("00");
			TransactionType.CashWithdrawal = new EFTConstant<string>("01");
			TransactionType.DebitAdjustment = new EFTConstant<string>("02");
			TransactionType.CheckCash = new EFTConstant<string>("03");
			TransactionType.CheckVerification = new EFTConstant<string>("04");
			TransactionType.EuroCheque = new EFTConstant<string>("05");
			TransactionType.TravellersCheck = new EFTConstant<string>("06");
			TransactionType.LetterOfCredit = new EFTConstant<string>("07");
			TransactionType.Giro = new EFTConstant<string>("08");
			TransactionType.GoodsAndServicesWithCashback = new EFTConstant<string>("09");
			TransactionType.WireTransfer = new EFTConstant<string>("10");
			TransactionType.QuasiCash = new EFTConstant<string>("11");
			TransactionType.GeneralDebit = new EFTConstant<string>("12");
			TransactionType.VisaCashLoadSettlementReversal = new EFTConstant<string>("19");
			TransactionType.ReturnRefund = new EFTConstant<string>("20");
			TransactionType.Deposit = new EFTConstant<string>("21");
			TransactionType.CreditAdjustment = new EFTConstant<string>("22");
			TransactionType.CheckDepositGuarantee = new EFTConstant<string>("23");
			TransactionType.CheckDeposit = new EFTConstant<string>("24");
			TransactionType.GeneralCredit = new EFTConstant<string>("25");
			TransactionType.MerchandiseRequest = new EFTConstant<string>("28");
			TransactionType.VisaCashLoadSettlement = new EFTConstant<string>("29");
			TransactionType.AvailableBalanceInquiry = new EFTConstant<string>("30");
			TransactionType.BalanceInquiry = new EFTConstant<string>("31");
			TransactionType.GeneralInquiry = new EFTConstant<string>("32");
			TransactionType.FullStatementInquiry = new EFTConstant<string>("35");
			TransactionType.MerchandiseInquiry = new EFTConstant<string>("36");
			TransactionType.CardVerificationInquiry = new EFTConstant<string>("37");
			TransactionType.MiniStatementInquiry = new EFTConstant<string>("38");
			TransactionType.LinkedAccountInquiry = new EFTConstant<string>("39");
			TransactionType.CardholderAccountsTransfer = new EFTConstant<string>("40");
			TransactionType.GeneralTransfer = new EFTConstant<string>("42");
			TransactionType.PaymentFromAccount = new EFTConstant<string>("50");
			TransactionType.PaymentByDeposit = new EFTConstant<string>("51");
			TransactionType.GeneralPayment = new EFTConstant<string>("52");
			TransactionType.PaymentToAccount = new EFTConstant<string>("53");
			TransactionType.PaymentFromAccountToAccount = new EFTConstant<string>("54");
			TransactionType.PlaceHoldOnCard = new EFTConstant<string>("90");
			TransactionType.GeneralAdmin = new EFTConstant<string>("91");
			TransactionType.ChangePIN = new EFTConstant<string>("92");
			TransactionType.DeadEnd = new EFTConstant<string>("93");
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.AvailableBalanceInquiry, TransactionType.AvailableBalanceInquiry);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.BalanceInquiry, TransactionType.BalanceInquiry);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.CardholderAccountsTransfer, TransactionType.CardholderAccountsTransfer);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.CardVerificationInquiry, TransactionType.CardVerificationInquiry);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.CashWithdrawal, TransactionType.CashWithdrawal);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.ChangePIN, TransactionType.ChangePIN);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.CheckCash, TransactionType.CheckCash);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.CheckDeposit, TransactionType.CheckDeposit);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.CheckDepositGuarantee, TransactionType.CheckDepositGuarantee);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.CheckVerification, TransactionType.CheckVerification);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.CreditAdjustment, TransactionType.CreditAdjustment);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.DeadEnd, TransactionType.DeadEnd);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.DebitAdjustment, TransactionType.DebitAdjustment);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.Deposit, TransactionType.Deposit);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.EuroCheque, TransactionType.EuroCheque);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.FullStatementInquiry, TransactionType.FullStatementInquiry);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.GeneralAdmin, TransactionType.GeneralAdmin);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.GeneralCredit, TransactionType.GeneralCredit);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.GeneralDebit, TransactionType.GeneralDebit);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.GeneralInquiry, TransactionType.GeneralInquiry);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.GeneralPayment, TransactionType.GeneralPayment);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.GeneralTransfer, TransactionType.GeneralTransfer);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.Giro, TransactionType.Giro);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.GoodsAndServices, TransactionType.GoodsAndServices);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.GoodsAndServicesWithCashback, TransactionType.GoodsAndServicesWithCashback);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.LetterOfCredit, TransactionType.LetterOfCredit);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.LinkedAccountInquiry, TransactionType.LinkedAccountInquiry);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.MerchandiseInquiry, TransactionType.MerchandiseInquiry);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.MerchandiseRequest, TransactionType.MerchandiseRequest);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.MiniStatementInquiry, TransactionType.MiniStatementInquiry);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.PaymentByDeposit, TransactionType.PaymentByDeposit);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.PaymentFromAccount, TransactionType.PaymentFromAccount);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.PaymentFromAccountToAccount, TransactionType.PaymentFromAccountToAccount);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.PaymentToAccount, TransactionType.PaymentToAccount);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.PlaceHoldOnCard, TransactionType.PlaceHoldOnCard);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.QuasiCash, TransactionType.QuasiCash);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.ReturnRefund, TransactionType.ReturnRefund);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.TravellersCheck, TransactionType.TravellersCheck);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.VisaCashLoadSettlement, TransactionType.VisaCashLoadSettlement);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.VisaCashLoadSettlementReversal, TransactionType.VisaCashLoadSettlementReversal);
			EFTProperties<TransactionTypeEnum>.Add(TransactionTypeEnum.WireTransfer, TransactionType.WireTransfer);
		}
	}
}
