using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class POSEntryMode : Empty
	{
		public Messages.Postbridge.Helpers.POSEntryMode Mode
		{
			get
			{
				return Messages.Postbridge.Helpers.POSEntryMode.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public PANEntryModeEnum PANEntryMode
		{
			get
			{
				return this.Mode.PANEntryMode;
			}
			set
			{
				Messages.Postbridge.Helpers.POSEntryMode mode = this.Mode;
				mode.PANEntryMode = value;
				this.Mode = mode;
			}
		}

		public PINEntryCapabilityEnum PINEntryCapability
		{
			get
			{
				return this.Mode.PINEntryCapability;
			}
			set
			{
				Messages.Postbridge.Helpers.POSEntryMode mode = this.Mode;
				mode.PINEntryCapability = value;
				this.Mode = mode;
			}
		}
	}
}
