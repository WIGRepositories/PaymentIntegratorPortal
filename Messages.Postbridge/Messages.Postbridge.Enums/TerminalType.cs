using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class TerminalType : EFTProperties<TerminalTypeEnum>
	{
		public static EFTConstant<string> AdministrativeTerminal;

		public static EFTConstant<string> POSTerminal;

		public static EFTConstant<string> ATM;

		public static EFTConstant<string> HomeTerminal;

		public static EFTConstant<string> ElectronicCashRegister;

		public static EFTConstant<string> DialTerminal;

		public static EFTConstant<string> TravellersCheckMachine;

		public static EFTConstant<string> FuelMachine;

		public static EFTConstant<string> ScripMachine;

		public static EFTConstant<string> CouponMachine;

		public static EFTConstant<string> TicketMachine;

		public static EFTConstant<string> PointOfBankingTerminal;

		public static EFTConstant<string> Teller;

		public static EFTConstant<string> FranchiseTeller;

		public static EFTConstant<string> PersonalBanking;

		public static EFTConstant<string> PublicUtility;

		public static EFTConstant<string> Vending;

		public static EFTConstant<string> SelfService;

		public static EFTConstant<string> Authorization;

		public static EFTConstant<string> Payment;

		public static EFTConstant<string> VRU;

		public static EFTConstant<string> SmartPhone;

		public static EFTConstant<string> InteractiveTelevision;

		public static EFTConstant<string> PersonalDigitalAssistant;

		public static EFTConstant<string> ScreenPhone;

		public static EFTConstant<string> ECommerceNoEncryptionNoAuthentication;

		public static EFTConstant<string> ECommerceSETEncryptionNotAuthenticated;

		public static EFTConstant<string> ECommerceSETEncryptionAuthenticated;

		public static EFTConstant<string> ECommerceSETEncryptionChipCryptogramNotAuthenticated;

		public static EFTConstant<string> ECommerceSETEncryptionChipCryptogramAuthenticated;

		public static EFTConstant<string> ECommerceSSLNotAuthenticated;

		public static EFTConstant<string> ECommerceSSLAuthenticated;

		static TerminalType()
		{
			TerminalType.AdministrativeTerminal = new EFTConstant<string>("00");
			TerminalType.POSTerminal = new EFTConstant<string>("01");
			TerminalType.ATM = new EFTConstant<string>("02");
			TerminalType.HomeTerminal = new EFTConstant<string>("03");
			TerminalType.ElectronicCashRegister = new EFTConstant<string>("04");
			TerminalType.DialTerminal = new EFTConstant<string>("05");
			TerminalType.TravellersCheckMachine = new EFTConstant<string>("06");
			TerminalType.FuelMachine = new EFTConstant<string>("07");
			TerminalType.ScripMachine = new EFTConstant<string>("08");
			TerminalType.CouponMachine = new EFTConstant<string>("09");
			TerminalType.TicketMachine = new EFTConstant<string>("10");
			TerminalType.PointOfBankingTerminal = new EFTConstant<string>("11");
			TerminalType.Teller = new EFTConstant<string>("12");
			TerminalType.FranchiseTeller = new EFTConstant<string>("13");
			TerminalType.PersonalBanking = new EFTConstant<string>("14");
			TerminalType.PublicUtility = new EFTConstant<string>("15");
			TerminalType.Vending = new EFTConstant<string>("16");
			TerminalType.SelfService = new EFTConstant<string>("17");
			TerminalType.Authorization = new EFTConstant<string>("18");
			TerminalType.Payment = new EFTConstant<string>("19");
			TerminalType.VRU = new EFTConstant<string>("20");
			TerminalType.SmartPhone = new EFTConstant<string>("21");
			TerminalType.InteractiveTelevision = new EFTConstant<string>("22");
			TerminalType.PersonalDigitalAssistant = new EFTConstant<string>("23");
			TerminalType.ScreenPhone = new EFTConstant<string>("24");
			TerminalType.ECommerceNoEncryptionNoAuthentication = new EFTConstant<string>("90");
			TerminalType.ECommerceSETEncryptionNotAuthenticated = new EFTConstant<string>("91");
			TerminalType.ECommerceSETEncryptionAuthenticated = new EFTConstant<string>("92");
			TerminalType.ECommerceSETEncryptionChipCryptogramNotAuthenticated = new EFTConstant<string>("93");
			TerminalType.ECommerceSETEncryptionChipCryptogramAuthenticated = new EFTConstant<string>("94");
			TerminalType.ECommerceSSLNotAuthenticated = new EFTConstant<string>("95");
			TerminalType.ECommerceSSLAuthenticated = new EFTConstant<string>("96");
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.AdministrativeTerminal, TerminalType.AdministrativeTerminal);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ATM, TerminalType.ATM);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.Authorization, TerminalType.Authorization);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.CouponMachine, TerminalType.CouponMachine);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.DialTerminal, TerminalType.DialTerminal);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ECommerceNoEncryptionNoAuthentication, TerminalType.ECommerceNoEncryptionNoAuthentication);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ECommerceSETEncryptionAuthenticated, TerminalType.ECommerceSETEncryptionAuthenticated);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ECommerceSETEncryptionChipCryptogramAuthenticated, TerminalType.ECommerceSETEncryptionChipCryptogramAuthenticated);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ECommerceSETEncryptionChipCryptogramNotAuthenticated, TerminalType.ECommerceSETEncryptionChipCryptogramNotAuthenticated);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ECommerceSETEncryptionNotAuthenticated, TerminalType.ECommerceSETEncryptionNotAuthenticated);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ECommerceSSLAuthenticated, TerminalType.ECommerceSSLAuthenticated);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ECommerceSSLNotAuthenticated, TerminalType.ECommerceSSLNotAuthenticated);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ElectronicCashRegister, TerminalType.ElectronicCashRegister);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.FranchiseTeller, TerminalType.FranchiseTeller);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.FuelMachine, TerminalType.FuelMachine);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.HomeTerminal, TerminalType.HomeTerminal);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.InteractiveTelevision, TerminalType.InteractiveTelevision);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.Payment, TerminalType.Payment);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.PersonalBanking, TerminalType.PersonalBanking);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.PersonalDigitalAssistant, TerminalType.PersonalDigitalAssistant);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.PointOfBankingTerminal, TerminalType.PointOfBankingTerminal);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.POSTerminal, TerminalType.POSTerminal);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.PublicUtility, TerminalType.PublicUtility);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ScreenPhone, TerminalType.ScreenPhone);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.ScripMachine, TerminalType.ScripMachine);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.SelfService, TerminalType.SelfService);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.SmartPhone, TerminalType.SmartPhone);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.Teller, TerminalType.Teller);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.TicketMachine, TerminalType.TicketMachine);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.TravellersCheckMachine, TerminalType.TravellersCheckMachine);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.Vending, TerminalType.Vending);
			EFTProperties<TerminalTypeEnum>.Add(TerminalTypeEnum.VRU, TerminalType.VRU);
		}
	}
}
