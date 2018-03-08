using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class TerminalOutputCapability : EFTProperties<TerminalOutputCapabilityEnum>
	{
		public static EFTConstant<string> Unknown;

		public static EFTConstant<string> None;

		public static EFTConstant<string> Printing;

		public static EFTConstant<string> Display;

		public static EFTConstant<string> PrintingAndDisplay;

		static TerminalOutputCapability()
		{
			TerminalOutputCapability.Unknown = new EFTConstant<string>("0");
			TerminalOutputCapability.None = new EFTConstant<string>("1");
			TerminalOutputCapability.Printing = new EFTConstant<string>("2");
			TerminalOutputCapability.Display = new EFTConstant<string>("3");
			TerminalOutputCapability.PrintingAndDisplay = new EFTConstant<string>("4");
			EFTProperties<TerminalOutputCapabilityEnum>.Add(TerminalOutputCapabilityEnum.Display, TerminalOutputCapability.Display);
			EFTProperties<TerminalOutputCapabilityEnum>.Add(TerminalOutputCapabilityEnum.None, TerminalOutputCapability.None);
			EFTProperties<TerminalOutputCapabilityEnum>.Add(TerminalOutputCapabilityEnum.Printing, TerminalOutputCapability.Printing);
			EFTProperties<TerminalOutputCapabilityEnum>.Add(TerminalOutputCapabilityEnum.PrintingAndDisplay, TerminalOutputCapability.PrintingAndDisplay);
			EFTProperties<TerminalOutputCapabilityEnum>.Add(TerminalOutputCapabilityEnum.Unknown, TerminalOutputCapability.Unknown);
		}
	}
}
