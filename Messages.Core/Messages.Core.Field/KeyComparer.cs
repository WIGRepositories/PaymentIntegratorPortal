using System;
using System.Collections.Generic;

namespace Messages.Core.Field
{
	internal class KeyComparer<T> : IComparer<T>
	{
		public int Compare(T x, T y)
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			string empty3 = string.Empty;
			string empty4 = string.Empty;
			string empty5 = string.Empty;
			string empty6 = string.Empty;
			this.Split(x, ref empty, ref empty3, ref empty5);
			this.Split(y, ref empty2, ref empty4, ref empty6);
			int num = string.Compare(empty, empty2);
			if (num == 0)
			{
				num = string.Compare(empty3, empty4);
				if (num == 0)
				{
					num = string.Compare(empty5, empty6);
				}
			}
			return num;
		}

		private void Split(T text, ref string s1, ref string s2, ref string s3)
		{
			string text2 = text.ToString();
			if (text2.Length <= 3)
			{
				s1 = text2.PadLeft(3, '0').Replace('-', ' ');
				s2 = "000";
				s3 = "000";
				return;
			}
			if (text2.Length <= 6)
			{
				text2 = text2.PadLeft(6, '0');
				s1 = text2.Substring(0, 3);
				s2 = text2.Substring(3, 3);
				s3 = "000";
				return;
			}
			text2 = text2.PadLeft(9, '0');
			s1 = text2.Substring(0, 3);
			s2 = text2.Substring(3, 3);
			s3 = text2.Substring(6, 3);
		}
	}
}
