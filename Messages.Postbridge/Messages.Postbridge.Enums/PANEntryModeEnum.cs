using System;

namespace Messages.Postbridge.Enums
{
	public enum PANEntryModeEnum
	{
		Unknown,
		Manual,
		MagneticStripe,
		BarCode,
		OCR,
		ICC_CVVCanBeChecked,
		ContactlessICC,
		MagneticStripe_CVVCanBeChecked,
		ContactlessMagneticStripe,
		ICC_CVVCannotBeChecked,
		SameAsOriginal
	}
}
