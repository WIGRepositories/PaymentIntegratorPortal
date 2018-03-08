using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class CardCaptureCapability : EFTProperties<CardCaptureCapabilityEnum>
	{
		public static EFTConstant<string> None;

		public static EFTConstant<string> CardCapture;

		static CardCaptureCapability()
		{
			CardCaptureCapability.None = new EFTConstant<string>("0");
			CardCaptureCapability.CardCapture = new EFTConstant<string>("1");
			EFTProperties<CardCaptureCapabilityEnum>.Add(CardCaptureCapabilityEnum.CardCapture, CardCaptureCapability.CardCapture);
			EFTProperties<CardCaptureCapabilityEnum>.Add(CardCaptureCapabilityEnum.None, CardCaptureCapability.None);
		}
	}
}
