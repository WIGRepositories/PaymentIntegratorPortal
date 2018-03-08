using System;
using System.Security.Cryptography;

namespace Messages.Licensing
{
	public sealed class RSAFunctions
	{
		public static byte[] SignData(RSAKey key, byte[] dataToSign)
		{
			return key.Key.SignData(dataToSign, new SHA1CryptoServiceProvider());
		}

		public static bool VerifyData(RSAKey key, byte[] hash, byte[] dataSigned)
		{
			return key.Key.VerifyData(dataSigned, new SHA1CryptoServiceProvider(), hash);
		}
	}
}
