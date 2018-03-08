using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class CardholderAuthenticationCapability : EFTProperties<CardholderAuthenticationCapabilityEnum>
	{
		public static EFTConstant<string> NoElectronicAuthentication;

		public static EFTConstant<string> PIN;

		public static EFTConstant<string> ElectronicSignatureAnalysis;

		public static EFTConstant<string> Biometrics;

		public static EFTConstant<string> Biographic;

		public static EFTConstant<string> ElectronicAuthenticationInoperative;

		public static EFTConstant<string> Other;

		static CardholderAuthenticationCapability()
		{
			CardholderAuthenticationCapability.NoElectronicAuthentication = new EFTConstant<string>("0");
			CardholderAuthenticationCapability.PIN = new EFTConstant<string>("1");
			CardholderAuthenticationCapability.ElectronicSignatureAnalysis = new EFTConstant<string>("2");
			CardholderAuthenticationCapability.Biometrics = new EFTConstant<string>("3");
			CardholderAuthenticationCapability.Biographic = new EFTConstant<string>("4");
			CardholderAuthenticationCapability.ElectronicAuthenticationInoperative = new EFTConstant<string>("5");
			CardholderAuthenticationCapability.Other = new EFTConstant<string>("6");
			EFTProperties<CardholderAuthenticationCapabilityEnum>.Add(CardholderAuthenticationCapabilityEnum.Biographic, CardholderAuthenticationCapability.Biographic);
			EFTProperties<CardholderAuthenticationCapabilityEnum>.Add(CardholderAuthenticationCapabilityEnum.Biometrics, CardholderAuthenticationCapability.Biometrics);
			EFTProperties<CardholderAuthenticationCapabilityEnum>.Add(CardholderAuthenticationCapabilityEnum.ElectronicAuthenticationInoperative, CardholderAuthenticationCapability.ElectronicAuthenticationInoperative);
			EFTProperties<CardholderAuthenticationCapabilityEnum>.Add(CardholderAuthenticationCapabilityEnum.ElectronicSignatureAnalysis, CardholderAuthenticationCapability.ElectronicSignatureAnalysis);
			EFTProperties<CardholderAuthenticationCapabilityEnum>.Add(CardholderAuthenticationCapabilityEnum.NoElectronicAuthentication, CardholderAuthenticationCapability.NoElectronicAuthentication);
			EFTProperties<CardholderAuthenticationCapabilityEnum>.Add(CardholderAuthenticationCapabilityEnum.Other, CardholderAuthenticationCapability.Other);
			EFTProperties<CardholderAuthenticationCapabilityEnum>.Add(CardholderAuthenticationCapabilityEnum.PIN, CardholderAuthenticationCapability.PIN);
		}
	}
}
