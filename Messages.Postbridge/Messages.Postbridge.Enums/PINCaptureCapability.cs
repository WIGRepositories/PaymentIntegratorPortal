using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class PINCaptureCapability : EFTProperties<PINCaptureCapabilityEnum>
	{
		public static EFTConstant<string> NoPINCaptureCapability;

		public static EFTConstant<string> DevicePINCaptureCapabilityUnknown;

		public static EFTConstant<string> FourCharacters;

		public static EFTConstant<string> FiveCharacters;

		public static EFTConstant<string> SixCharacters;

		public static EFTConstant<string> SevenCharacters;

		public static EFTConstant<string> EightCharacters;

		public static EFTConstant<string> NineCharacters;

		public static EFTConstant<string> TenCharacters;

		public static EFTConstant<string> ElevenCharacters;

		public static EFTConstant<string> TwelveCharacters;

		static PINCaptureCapability()
		{
			PINCaptureCapability.NoPINCaptureCapability = new EFTConstant<string>("0");
			PINCaptureCapability.DevicePINCaptureCapabilityUnknown = new EFTConstant<string>("1");
			PINCaptureCapability.FourCharacters = new EFTConstant<string>("4");
			PINCaptureCapability.FiveCharacters = new EFTConstant<string>("5");
			PINCaptureCapability.SixCharacters = new EFTConstant<string>("6");
			PINCaptureCapability.SevenCharacters = new EFTConstant<string>("7");
			PINCaptureCapability.EightCharacters = new EFTConstant<string>("8");
			PINCaptureCapability.NineCharacters = new EFTConstant<string>("9");
			PINCaptureCapability.TenCharacters = new EFTConstant<string>("A");
			PINCaptureCapability.ElevenCharacters = new EFTConstant<string>("B");
			PINCaptureCapability.TwelveCharacters = new EFTConstant<string>("C");
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.DevicePINCaptureCapabilityUnknown, PINCaptureCapability.DevicePINCaptureCapabilityUnknown);
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.EightCharacters, PINCaptureCapability.EightCharacters);
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.ElevenCharacters, PINCaptureCapability.ElevenCharacters);
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.FiveCharacters, PINCaptureCapability.FiveCharacters);
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.FourCharacters, PINCaptureCapability.FourCharacters);
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.NineCharacters, PINCaptureCapability.NineCharacters);
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.NoPINCaptureCapability, PINCaptureCapability.NoPINCaptureCapability);
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.SevenCharacters, PINCaptureCapability.SevenCharacters);
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.SixCharacters, PINCaptureCapability.SixCharacters);
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.TenCharacters, PINCaptureCapability.TenCharacters);
			EFTProperties<PINCaptureCapabilityEnum>.Add(PINCaptureCapabilityEnum.TwelveCharacters, PINCaptureCapability.TwelveCharacters);
		}
	}
}
