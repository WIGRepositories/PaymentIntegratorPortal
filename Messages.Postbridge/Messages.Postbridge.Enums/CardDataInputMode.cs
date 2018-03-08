using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class CardDataInputMode : EFTProperties<CardDataInputModeEnum>
	{
		public static EFTConstant<string> Unknown;

		public static EFTConstant<string> ManualNoTerminal;

		public static EFTConstant<string> MagneticStripe;

		public static EFTConstant<string> BarCode;

		public static EFTConstant<string> OCR;

		public static EFTConstant<string> ICC;

		public static EFTConstant<string> KeyEntered;

		public static EFTConstant<string> ContactlessICC;

		public static EFTConstant<string> ContactlessMagneticStripe;

		static CardDataInputMode()
		{
			CardDataInputMode.Unknown = new EFTConstant<string>("0");
			CardDataInputMode.ManualNoTerminal = new EFTConstant<string>("1");
			CardDataInputMode.MagneticStripe = new EFTConstant<string>("2");
			CardDataInputMode.BarCode = new EFTConstant<string>("3");
			CardDataInputMode.OCR = new EFTConstant<string>("4");
			CardDataInputMode.ICC = new EFTConstant<string>("5");
			CardDataInputMode.KeyEntered = new EFTConstant<string>("6");
			CardDataInputMode.ContactlessICC = new EFTConstant<string>("7");
			CardDataInputMode.ContactlessMagneticStripe = new EFTConstant<string>("8");
			EFTProperties<CardDataInputModeEnum>.Add(CardDataInputModeEnum.BarCode, CardDataInputMode.BarCode);
			EFTProperties<CardDataInputModeEnum>.Add(CardDataInputModeEnum.ContactlessICC, CardDataInputMode.ContactlessICC);
			EFTProperties<CardDataInputModeEnum>.Add(CardDataInputModeEnum.ContactlessMagneticStripe, CardDataInputMode.ContactlessMagneticStripe);
			EFTProperties<CardDataInputModeEnum>.Add(CardDataInputModeEnum.ICC, CardDataInputMode.ICC);
			EFTProperties<CardDataInputModeEnum>.Add(CardDataInputModeEnum.KeyEntered, CardDataInputMode.KeyEntered);
			EFTProperties<CardDataInputModeEnum>.Add(CardDataInputModeEnum.MagneticStripe, CardDataInputMode.MagneticStripe);
			EFTProperties<CardDataInputModeEnum>.Add(CardDataInputModeEnum.ManualNoTerminal, CardDataInputMode.ManualNoTerminal);
			EFTProperties<CardDataInputModeEnum>.Add(CardDataInputModeEnum.OCR, CardDataInputMode.OCR);
			EFTProperties<CardDataInputModeEnum>.Add(CardDataInputModeEnum.Unknown, CardDataInputMode.Unknown);
		}
	}
}
