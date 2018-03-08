using System;

namespace Messages.Postbridge.Enums
{
	public enum CardholderAuthenticationMethodEnum
	{
		NoElectronicAuthentication,
		PIN,
		ElectronicSignatureAnalysis,
		Biometrics,
		Biographic,
		Manual,
		Other
	}
}
