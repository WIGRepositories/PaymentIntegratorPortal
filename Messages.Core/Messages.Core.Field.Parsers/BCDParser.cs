using System;
using System.IO;

namespace Messages.Core.Field.Parsers
{
	[Serializable]
	public class BCDParser : Empty
	{
		public override string Parse(IField field, Stream stream)
		{
			return base.GetStringFromStream(stream, field.Size);
		}

		public override byte[] ByteParse(IField field, Stream stream)
		{
			string stringFromStream = base.GetStringFromStream(stream, field.Size * 2);
			byte[] array = (byte[])Array.CreateInstance(typeof(byte), field.Size);
			for (int i = 0; i < stringFromStream.Length; i += 2)
			{
				array[i / 2] = Convert.ToByte(stringFromStream.Substring(i, 2), 16);
			}
			return array;
		}
	}
}
