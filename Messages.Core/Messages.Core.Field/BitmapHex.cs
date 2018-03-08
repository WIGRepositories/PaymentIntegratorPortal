using System;
using System.Collections.Generic;
using System.Text;

namespace Messages.Core.Field
{
	[Serializable]
	public class BitmapHex : Bitmap
	{
		public BitmapHex(int startField)
		{
			this.startField = startField;
			base.MappedFields = new SortedList<int, IField>();
		}

		public override void BeforeEncode()
		{
			base.BeforeEncode();
			base.Bytes = Encoding.ASCII.GetBytes(BitConverter.ToString(base.Bytes).Replace("-", ""));
		}

		public override void AfterDecode()
		{
			this.GetHexBitmapData();
			base.AfterDecode();
		}

		private void GetHexBitmapData()
		{
			string @string = Encoding.ASCII.GetString(base.Bytes);
			base.Bytes = this.HexToByteArray(@string);
		}

		private byte[] HexToByteArray(string txt)
		{
			byte[] array = new byte[txt.Length / 2];
			for (int i = 0; i < txt.Length; i += 2)
			{
				array[i / 2] = Convert.ToByte(txt.Substring(i, 2), 16);
			}
			return array;
		}
	}
}
