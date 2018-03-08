using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Messages.Postbridge.Helpers
{
	public class StructuredDataItem
	{
		public KeyValuePair<string, string> Item
		{
			get;
			set;
		}

		public string Key
		{
			get
			{
				return this.Item.Key;
			}
		}

		public string Value
		{
			get
			{
				return this.Item.Value;
			}
		}

		public StructuredDataItem(string key, string value)
		{
			this.Item = new KeyValuePair<string, string>(key, value);
		}

		public StructuredDataItem(string tlv)
		{
			int num = 0;
			string key = this.ParseNext(tlv, ref num);
			string value = this.ParseNext(tlv, ref num);
			this.Item = new KeyValuePair<string, string>(key, value);
		}

		public StructuredDataItem(Stream stream)
		{
			string key = this.ParseNext(stream);
			string value = this.ParseNext(stream);
			this.Item = new KeyValuePair<string, string>(key, value);
		}

		public override string ToString()
		{
			return this.MakeTag(this.Item.Key) + this.MakeTag(this.Item.Value);
		}

		private string MakeTag(string item)
		{
			int length = item.Length;
			return length.ToString().Length.ToString() + length.ToString() + item;
		}

		private string ParseNext(string tlv, ref int pos)
		{
			int num = Convert.ToInt32(tlv.Substring(pos, 1));
			pos++;
			int num2 = Convert.ToInt32(tlv.Substring(pos, num));
			pos += num;
			string result = tlv.Substring(pos, num2);
			pos += num2;
			return result;
		}

		private string ParseNext(Stream stream)
		{
			int bufferLen = this.ParseStringAsLength(stream, 1);
			int len = this.ParseStringAsLength(stream, bufferLen);
			return this.ReadStringFromStream(stream, len);
		}

		private int ParseStringAsLength(Stream stream, int bufferLen)
		{
			return Convert.ToInt32(this.ReadStringFromStream(stream, bufferLen));
		}

		private string ReadStringFromStream(Stream stream, int len)
		{
			byte[] array = (byte[])Array.CreateInstance(typeof(byte), len);
			stream.Read(array, 0, len);
			return Encoding.ASCII.GetString(array);
		}
	}
}
