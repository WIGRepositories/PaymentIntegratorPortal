using Messages.Postbridge.Enums;
using System;

namespace Messages.Postbridge.Helpers
{
	public class POSEntryMode
	{
		public PANEntryModeEnum PANEntryMode
		{
			get;
			set;
		}

		public PINEntryCapabilityEnum PINEntryCapability
		{
			get;
			set;
		}

		public POSEntryMode(PANEntryModeEnum panEntryMode, PINEntryCapabilityEnum pinEntryCapability)
		{
			this.PANEntryMode = panEntryMode;
			this.PINEntryCapability = pinEntryCapability;
		}

		public POSEntryMode(string panEntryMode, string pinEntryCapability)
		{
			this.InitStrings(panEntryMode, pinEntryCapability);
		}

		public POSEntryMode(string posEntryMode)
		{
			this.InitStrings(posEntryMode.Substring(0, 2), posEntryMode.Substring(2, 1));
		}

		public override string ToString()
		{
			return EFTProperties<PANEntryModeEnum>.Value(this.PANEntryMode).Value + EFTProperties<PINEntryCapabilityEnum>.Value(this.PINEntryCapability).Value;
		}

		public static POSEntryMode FromString(string posEntryMode)
		{
			return new POSEntryMode(posEntryMode);
		}

		private void InitStrings(string panEntryMode, string pinEntryCapability)
		{
			this.PANEntryMode = EFTProperties<PANEntryModeEnum>.Enum(panEntryMode);
			this.PINEntryCapability = EFTProperties<PINEntryCapabilityEnum>.Enum(pinEntryCapability);
		}
	}
}
