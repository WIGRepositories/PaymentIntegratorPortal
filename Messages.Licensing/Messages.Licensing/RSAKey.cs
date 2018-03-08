using System;
using System.Security.Cryptography;

namespace Messages.Licensing
{
	public sealed class RSAKey : IDisposable
	{
		private RSACryptoServiceProvider m_rsa;

		private bool m_disposing;

		public RSACryptoServiceProvider Key
		{
			get
			{
				return this.m_rsa;
			}
		}

		public string PublicKey
		{
			get
			{
				return this.m_rsa.ToXmlString(false);
			}
		}

		public string PrivateKey
		{
			get
			{
				if (this.m_rsa.PublicOnly)
				{
					throw new InvalidOperationException("RSA key does not include private part");
				}
				return this.m_rsa.ToXmlString(true);
			}
		}

		public RSAKey(int keyLength, CspProviderFlags flags)
		{
			this.m_rsa = new RSACryptoServiceProvider(keyLength, new CspParameters
			{
				Flags = flags
			});
		}

		public RSAKey(string xmlKeys)
		{
			this.m_rsa = new RSACryptoServiceProvider();
			this.m_rsa.FromXmlString(xmlKeys);
		}

		private void Dispose(bool disposing)
		{
			if (!this.m_disposing)
			{
				this.m_rsa.Dispose();
			}
			this.m_disposing = true;
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
