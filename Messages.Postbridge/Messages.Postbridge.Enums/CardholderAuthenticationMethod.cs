using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class CardholderAuthenticationMethod : EFTProperties<CardholderAuthenticationMethodEnum>
	{
		public static EFTConstant<string> NoElectronicAuthentication;

		public static EFTConstant<string> PIN;

		public static EFTConstant<string> ElectronicSignatureAnalysis;

		public static EFTConstant<string> Biometrics;

		public static EFTConstant<string> Biographic;

		public static EFTConstant<string> Manual;

		public static EFTConstant<string> Other;

		static CardholderAuthenticationMethod()
		{
			CardholderAuthenticationMethod.NoElectronicAuthentication = new EFTConstant<string>("0");
			CardholderAuthenticationMethod.PIN = new EFTConstant<string>("1");
			CardholderAuthenticationMethod.ElectronicSignatureAnalysis = new EFTConstant<string>("2");
			CardholderAuthenticationMethod.Biometrics = new EFTConstant<string>("3");
			CardholderAuthenticationMethod.Biographic = new EFTConstant<string>("4");
			CardholderAuthenticationMethod.Manual = new EFTConstant<string>("5");
			CardholderAuthenticationMethod.Other = new EFTConstant<string>("6");
			EFTProperties<CardholderAuthenticationMethodEnum>.Add(CardholderAuthenticationMethodEnum.Biographic, CardholderAuthenticationMethod.Biographic);
			EFTProperties<CardholderAuthenticationMethodEnum>.Add(CardholderAuthenticationMethodEnum.Biometrics, CardholderAuthenticationMethod.Biometrics);
			EFTProperties<CardholderAuthenticationMethodEnum>.Add(CardholderAuthenticationMethodEnum.ElectronicSignatureAnalysis, CardholderAuthenticationMethod.ElectronicSignatureAnalysis);
			EFTProperties<CardholderAuthenticationMethodEnum>.Add(CardholderAuthenticationMethodEnum.Manual, CardholderAuthenticationMethod.Manual);
			EFTProperties<CardholderAuthenticationMethodEnum>.Add(CardholderAuthenticationMethodEnum.NoElectronicAuthentication, CardholderAuthenticationMethod.NoElectronicAuthentication);
			EFTProperties<CardholderAuthenticationMethodEnum>.Add(CardholderAuthenticationMethodEnum.Other, CardholderAuthenticationMethod.Other);
			EFTProperties<CardholderAuthenticationMethodEnum>.Add(CardholderAuthenticationMethodEnum.PIN, CardholderAuthenticationMethod.PIN);
		}
	}
}
