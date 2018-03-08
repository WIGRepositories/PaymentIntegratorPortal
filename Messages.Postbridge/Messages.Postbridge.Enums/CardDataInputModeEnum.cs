using System;

namespace Messages.Postbridge.Enums
{
	public enum CardDataInputModeEnum
	{
		Unknown,
		ManualNoTerminal,
		MagneticStripe,
		BarCode,
		OCR,
		ICC,
		KeyEntered,
		ContactlessICC,
		ContactlessMagneticStripe
	}
}
