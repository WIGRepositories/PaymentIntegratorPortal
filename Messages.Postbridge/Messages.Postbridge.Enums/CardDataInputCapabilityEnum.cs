using System;

namespace Messages.Postbridge.Enums
{
	public enum CardDataInputCapabilityEnum
	{
		Unknown,
		ManualNoTerminal,
		MagneticStripe,
		BarCode,
		OCR,
		MagneticStripeKeyEntryICC,
		KeyEntry,
		MagneticStripeKeyEntry,
		MagneticStripeICC,
		ICC,
		ContactlessICC,
		ContactlessMagneticStripe
	}
}
