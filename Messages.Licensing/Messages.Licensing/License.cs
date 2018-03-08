using System;
using System.Text;

namespace Messages.Licensing
{
	public sealed class License
	{
		private bool validated;

		private static string PRODUCT_STR = "Product: ";

		private static string CUSTOMER_STR = "Customer: ";

		private static string LICENSE_STR = "License type: ";

		private static string VALIDUNTIL_STR = "Valid until: ";

		public string RSAPublicKey
		{
			get;
			set;
		}

		public string Project
		{
			get;
			set;
		}

		public string Customer
		{
			get;
			set;
		}

		public LicenseType Type
		{
			get;
			set;
		}

		public DateTime ExpirationDate
		{
			get;
			set;
		}

		public string LicenseHash
		{
			get;
			set;
		}

		public bool IsValid
		{
			get
			{
				return this.validated && DateTime.Now.CompareTo(this.ExpirationDate) <= 0;
			}
		}

		public static License FromString(string txt)
		{
			string[] array = txt.Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.None);
			return new License
			{
				Project = array[2].Replace(License.PRODUCT_STR, ""),
				Customer = array[3].Replace(License.CUSTOMER_STR, ""),
				Type = (LicenseType)Enum.Parse(typeof(LicenseType), array[5].Replace(License.LICENSE_STR, "")),
				ExpirationDate = Convert.ToDateTime(array[6].Replace(License.VALIDUNTIL_STR, "")),
				LicenseHash = array[8]
			};
		}

		public override string ToString()
		{
			return this.ToStringInternal() + "\r\n\r\n" + this.LicenseHash + "\r\n========LICENSE FILE========";
		}

		public void Sign(RSAKey privateKey)
		{
			this.LicenseHash = this.ByteArrayToHex(RSAFunctions.SignData(privateKey, this.StringToBytes(this.ToStringInternal())));
		}

		public bool Validate()
		{
			using (RSAKey rSAKey = new RSAKey(this.RSAPublicKey))
			{
				this.validated = RSAFunctions.VerifyData(rSAKey, this.HexStringToByteArray(this.LicenseHash), this.StringToBytes(this.ToStringInternal()));
			}
			return this.IsValid;
		}

		private string ToStringInternal()
		{
			return string.Concat(new string[]
			{
				"========LICENSE FILE========\r\n\r\n",
				License.PRODUCT_STR,
				this.Project,
				"\r\n",
				License.CUSTOMER_STR,
				this.Customer,
				"\r\n\r\n",
				License.LICENSE_STR,
				this.Type.ToString(),
				"\r\n",
				License.VALIDUNTIL_STR,
				this.ExpirationDate.ToString("yyyy/MM/dd")
			});
		}

		private byte[] HexStringToByteArray(string txt)
		{
			byte[] array = (byte[])Array.CreateInstance(typeof(byte), txt.Length / 2);
			for (int i = 0; i < txt.Length; i += 2)
			{
				array[i / 2] = Convert.ToByte(txt.Substring(i, 2), 16);
			}
			return array;
		}

		private string ByteArrayToHex(byte[] b)
		{
			return BitConverter.ToString(b).Replace("-", "");
		}

		private byte[] StringToBytes(string txt)
		{
			return Encoding.ASCII.GetBytes(txt);
		}
	}
}
