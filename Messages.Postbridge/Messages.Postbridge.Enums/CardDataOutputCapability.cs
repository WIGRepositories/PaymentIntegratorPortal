using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class CardDataOutputCapability : EFTProperties<CardDataOutputCapabilityEnum>
	{
		public static EFTConstant<string> Unknown;

		public static EFTConstant<string> None;

		public static EFTConstant<string> MagneticStripeWrite;

		public static EFTConstant<string> ICC;

		static CardDataOutputCapability()
		{
			CardDataOutputCapability.Unknown = new EFTConstant<string>("0");
			CardDataOutputCapability.None = new EFTConstant<string>("1");
			CardDataOutputCapability.MagneticStripeWrite = new EFTConstant<string>("2");
			CardDataOutputCapability.ICC = new EFTConstant<string>("3");
			EFTProperties<CardDataOutputCapabilityEnum>.Add(CardDataOutputCapabilityEnum.ICC, CardDataOutputCapability.ICC);
			EFTProperties<CardDataOutputCapabilityEnum>.Add(CardDataOutputCapabilityEnum.MagneticStripeWrite, CardDataOutputCapability.MagneticStripeWrite);
			EFTProperties<CardDataOutputCapabilityEnum>.Add(CardDataOutputCapabilityEnum.None, CardDataOutputCapability.None);
			EFTProperties<CardDataOutputCapabilityEnum>.Add(CardDataOutputCapabilityEnum.Unknown, CardDataOutputCapability.Unknown);
		}
	}
}
