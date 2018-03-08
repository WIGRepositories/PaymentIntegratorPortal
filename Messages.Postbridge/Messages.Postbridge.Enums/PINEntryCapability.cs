using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class PINEntryCapability : EFTProperties<PINEntryCapabilityEnum>
	{
		public static EFTConstant<string> Unknown;

		public static EFTConstant<string> TerminalCanAcceptPINs;

		public static EFTConstant<string> TerminalCannotAcceptPINs;

		static PINEntryCapability()
		{
			PINEntryCapability.Unknown = new EFTConstant<string>("0");
			PINEntryCapability.TerminalCanAcceptPINs = new EFTConstant<string>("1");
			PINEntryCapability.TerminalCannotAcceptPINs = new EFTConstant<string>("2");
			EFTProperties<PINEntryCapabilityEnum>.Add(PINEntryCapabilityEnum.TerminalCanAcceptPINs, PINEntryCapability.TerminalCanAcceptPINs);
			EFTProperties<PINEntryCapabilityEnum>.Add(PINEntryCapabilityEnum.TerminalCannotAcceptPINs, PINEntryCapability.TerminalCannotAcceptPINs);
			EFTProperties<PINEntryCapabilityEnum>.Add(PINEntryCapabilityEnum.Unknown, PINEntryCapability.Unknown);
		}
	}
}
