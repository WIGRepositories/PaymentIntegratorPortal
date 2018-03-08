using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages.Core.Field.Validators
{
	[Serializable]
	public class Empty : IFieldValidator
	{
		public virtual void Validate(string content)
		{
		}

		protected void CheckHour(string content)
		{
			int hour = this.TryParse(content.Substring(0, 2));
			int minute = this.TryParse(content.Substring(2, 2));
			int second = this.TryParse(content.Substring(4, 2));
			try
			{
				new DateTime(2010, 1, 1, hour, minute, second);
			}
			catch
			{
				throw new InvalidCastException(string.Format("Invalid time [{0}] found", content));
			}
		}

		protected void CheckMonthDay(string content)
		{
			int month = this.TryParse(content.Substring(0, 2));
			int day = this.TryParse(content.Substring(2, 2));
			try
			{
				new DateTime(2000, month, day);
			}
			catch
			{
				throw new InvalidCastException(string.Format("Invalid date [{0}] found", content));
			}
		}

		protected void CheckNumericRange(string content, int lowRange, int highRange)
		{
			this.CheckChars((char ch) => char.IsDigit(ch), content);
			int num = this.TryParse(content);
			if (num < lowRange || num > highRange)
			{
				throw new InvalidCastException(string.Format("Invalid value [{0}]", content));
			}
		}

		protected int TryParse(string text)
		{
			int result;
			if (int.TryParse(text, out result))
			{
				return result;
			}
			throw new InvalidCastException(string.Format("Invalid value [{0}]", text));
		}

		protected void CheckChars(List<Func<char, bool>> funcs, string content)
		{
			for (int i = 0; i < content.Length; i++)
			{
				char c = content[i];
				bool flag = false;
				foreach (Func<char, bool> current in funcs)
				{
					if (current(c))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					throw new InvalidCastException(string.Format("Invalid character [{0}] found", c));
				}
			}
		}

		protected void CheckChars(Func<char, bool> func, string content)
		{
			for (int i = 0; i < content.Length; i++)
			{
				char c = content[i];
				if (!func(c))
				{
					throw new InvalidCastException(string.Format("Invalid character [{0}] found", c));
				}
			}
		}

		protected bool IsSpecial(char ch)
		{
			return this.IsInChars(new char[]
			{
				'!',
				'@',
				'#',
				'$',
				'%',
				'^',
				'&',
				'*',
				'(',
				')',
				'-',
				'_',
				'+',
				'=',
				'{',
				'}',
				'[',
				']',
				'\\',
				'/',
				'|',
				'<',
				'>',
				'?',
				';',
				'"',
				'\'',
				' ',
				':',
				'.',
				',',
				'~'
			}, ch);
		}

		protected bool IsInChars(char[] chars, char ch)
		{
			return chars.Contains(ch);
		}
	}
}
