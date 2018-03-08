using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class CardDataInputCapability : EFTProperties<CardDataInputCapabilityEnum>
	{
		public static EFTConstant<string> Unknown;

		public static EFTConstant<string> ManualNoTerminal;

		public static EFTConstant<string> MagneticStripe;

		public static EFTConstant<string> BarCode;

		public static EFTConstant<string> OCR;

		public static EFTConstant<string> MagneticStripeKeyEntryICC;

		public static EFTConstant<string> KeyEntry;

		public static EFTConstant<string> MagneticStripeKeyEntry;

		public static EFTConstant<string> MagneticStripeICC;

		public static EFTConstant<string> ICC;

		public static EFTConstant<string> ContactlessICC;

		public static EFTConstant<string> ContactlessMagneticStripe;

		static CardDataInputCapability()
		{
			CardDataInputCapability.Unknown = new EFTConstant<string>("0");
			CardDataInputCapability.ManualNoTerminal = new EFTConstant<string>("1");
			CardDataInputCapability.MagneticStripe = new EFTConstant<string>("2");
			CardDataInputCapability.BarCode = new EFTConstant<string>("3");
			CardDataInputCapability.OCR = new EFTConstant<string>("4");
			CardDataInputCapability.MagneticStripeKeyEntryICC = new EFTConstant<string>("5");
			CardDataInputCapability.KeyEntry = new EFTConstant<string>("6");
			CardDataInputCapability.MagneticStripeKeyEntry = new EFTConstant<string>("7");
			CardDataInputCapability.MagneticStripeICC = new EFTConstant<string>("8");
			CardDataInputCapability.ICC = new EFTConstant<string>("9");
			CardDataInputCapability.ContactlessICC = new EFTConstant<string>("A");
			CardDataInputCapability.ContactlessMagneticStripe = new EFTConstant<string>("B");
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.BarCode, CardDataInputCapability.BarCode);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.ContactlessICC, CardDataInputCapability.ContactlessICC);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.ContactlessMagneticStripe, CardDataInputCapability.ContactlessMagneticStripe);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.ICC, CardDataInputCapability.ICC);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.KeyEntry, CardDataInputCapability.KeyEntry);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.MagneticStripe, CardDataInputCapability.MagneticStripe);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.MagneticStripeICC, CardDataInputCapability.MagneticStripeICC);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.MagneticStripeKeyEntry, CardDataInputCapability.MagneticStripeKeyEntry);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.MagneticStripeKeyEntryICC, CardDataInputCapability.MagneticStripeKeyEntryICC);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.ManualNoTerminal, CardDataInputCapability.ManualNoTerminal);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.OCR, CardDataInputCapability.OCR);
			EFTProperties<CardDataInputCapabilityEnum>.Add(CardDataInputCapabilityEnum.Unknown, CardDataInputCapability.Unknown);
		}
	}
}
