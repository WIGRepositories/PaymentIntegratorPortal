using System;
using System.Collections.Generic;

namespace Messages.Core.Field
{
	[Serializable]
	public class FieldMap
	{
		public SortedList<int, bool> Bits
		{
			get;
			set;
		}

		public FieldMap()
		{
			this.Bits = new SortedList<int, bool>(new KeyComparer<int>());
		}

		public bool IsSet(int fieldNumber)
		{
			return this.Bits[fieldNumber];
		}

		public bool IsSet(string fieldNumber)
		{
			return this.Bits[Convert.ToInt32(fieldNumber)];
		}

		public void Add(int fieldNumber)
		{
			this.Bits.Add(fieldNumber, false);
		}

		public void Set(int fieldNumber)
		{
			this.Bits[fieldNumber] = true;
		}

		public void Reset(int fieldNumber)
		{
			this.Bits[fieldNumber] = false;
		}

		public int[] GetKeys()
		{
			int[] array = (int[])Array.CreateInstance(typeof(int), this.Bits.Keys.Count);
			this.Bits.Keys.CopyTo(array, 0);
			return array;
		}
	}
}
