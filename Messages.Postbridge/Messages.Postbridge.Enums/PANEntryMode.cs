using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class PANEntryMode : EFTProperties<PANEntryModeEnum>
	{
		public static EFTConstant<string> Unknown;

		public static EFTConstant<string> Manual;

		public static EFTConstant<string> MagneticStripe;

		public static EFTConstant<string> BarCode;

		public static EFTConstant<string> OCR;

		public static EFTConstant<string> ICC_CVVCanBeChecked;

		public static EFTConstant<string> ContactlessICC;

		public static EFTConstant<string> MagneticStripe_CVVCanBeChecked;

		public static EFTConstant<string> ContactlessMagneticStripe;

		public static EFTConstant<string> ICC_CVVCannotBeChecked;

		public static EFTConstant<string> SameAsOriginal;

		static PANEntryMode()
		{
			PANEntryMode.Unknown = new EFTConstant<string>("00");
			PANEntryMode.Manual = new EFTConstant<string>("01");
			PANEntryMode.MagneticStripe = new EFTConstant<string>("02");
			PANEntryMode.BarCode = new EFTConstant<string>("03");
			PANEntryMode.OCR = new EFTConstant<string>("04");
			PANEntryMode.ICC_CVVCanBeChecked = new EFTConstant<string>("05");
			PANEntryMode.ContactlessICC = new EFTConstant<string>("07");
			PANEntryMode.MagneticStripe_CVVCanBeChecked = new EFTConstant<string>("90");
			PANEntryMode.ContactlessMagneticStripe = new EFTConstant<string>("91");
			PANEntryMode.ICC_CVVCannotBeChecked = new EFTConstant<string>("95");
			PANEntryMode.SameAsOriginal = new EFTConstant<string>("99");
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.BarCode, PANEntryMode.BarCode);
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.ContactlessICC, PANEntryMode.ContactlessICC);
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.ContactlessMagneticStripe, PANEntryMode.ContactlessMagneticStripe);
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.ICC_CVVCanBeChecked, PANEntryMode.ICC_CVVCanBeChecked);
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.ICC_CVVCannotBeChecked, PANEntryMode.ICC_CVVCannotBeChecked);
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.MagneticStripe, PANEntryMode.MagneticStripe);
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.MagneticStripe_CVVCanBeChecked, PANEntryMode.MagneticStripe_CVVCanBeChecked);
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.Manual, PANEntryMode.Manual);
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.OCR, PANEntryMode.OCR);
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.SameAsOriginal, PANEntryMode.SameAsOriginal);
			EFTProperties<PANEntryModeEnum>.Add(PANEntryModeEnum.Unknown, PANEntryMode.Unknown);
		}
	}
}
