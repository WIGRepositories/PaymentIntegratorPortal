using System;
using System.Collections.Generic;

namespace Messages.Core.Field
{
	[Serializable]
	public class Bitmap : Empty
	{
		protected int startField;

		protected List<int> fieldMap;

		public SortedList<int, IField> MappedFields
		{
			get;
			set;
		}

		public int GetStartField()
		{
			return this.startField;
		}

		public Bitmap()
		{
			this.startField = 0;
			this.MappedFields = new SortedList<int, IField>();
		}

		public Bitmap(int startField)
		{
			this.startField = startField;
			this.MappedFields = new SortedList<int, IField>();
		}

		public void AddMappedFieldRange(int startField, int endField, SortedList<int, IField> fields)
		{
			this.MappedFields.Clear();
			int[] keys = this.GetKeys(fields);
			for (int i = 0; i < keys.GetLength(0); i++)
			{
				if (keys[i] >= startField && keys[i] <= startField + 64 - 1)
				{
					this.MappedFields.Add(keys[i], fields[keys[i]]);
				}
			}
		}

		public List<int> GetDecodedBitmap()
		{
			return this.fieldMap;
		}

		public override void AfterDecode()
		{
			this.fieldMap = new List<int>();
			int num = 0;
			for (int i = 0; i < base.Bytes.GetLength(0); i++)
			{
				int num2 = (int)base.Bytes[i];
				for (int j = 0; j < 8; j++)
				{
					num++;
					int num3 = num2 & 128;
					num2 <<= 1;
					if (num3 == 128)
					{
						this.fieldMap.Add(num + this.startField);
					}
				}
			}
		}

		public override void BeforeEncode()
		{
			byte[] array = (byte[])Array.CreateInstance(typeof(byte), 8);
			int[] keys = this.GetKeys(this.MappedFields);
			int num = this.startField % 8;
			for (int i = 0; i < keys.Length; i++)
			{
				if (this.MappedFields[keys[i]].IsSet())
				{
					int num2 = (keys[i] - num - 1) / 8 - this.startField / 8;
					int num3 = 1 << 8 - (keys[i] - num) % 8;
					if (num3 == 256)
					{
						num3 = 1;
					}
					array[num2] = (byte)((int)array[num2] | num3);
				}
			}
			base.Bytes = array;
		}

		public override bool IsSet()
		{
			foreach (int current in this.MappedFields.Keys)
			{
				if (this.MappedFields[current].IsSet())
				{
					return true;
				}
			}
			return false;
		}

		protected int[] GetKeys(SortedList<int, IField> list)
		{
			int[] array = (int[])Array.CreateInstance(typeof(int), list.Keys.Count);
			list.Keys.CopyTo(array, 0);
			return array;
		}
	}
}
