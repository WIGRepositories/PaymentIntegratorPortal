using System;

namespace Messages.Postbridge.Enums
{
	public enum CardholderAuthenticationCapabilityEnum
	{
		NoElectronicAuthentication,
		PIN,
		ElectronicSignatureAnalysis,
		Biometrics,
		Biographic,
		ElectronicAuthenticationInoperative,
		Other
	}
}
