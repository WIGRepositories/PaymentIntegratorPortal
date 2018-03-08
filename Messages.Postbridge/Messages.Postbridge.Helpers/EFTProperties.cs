using System;
using System.Collections.Generic;

namespace Messages.Postbridge.Helpers
{
	public class EFTProperties<T>
	{
		protected static SortedDictionary<T, EFTConstant<string>> dict = new SortedDictionary<T, EFTConstant<string>>();

		protected static SortedDictionary<string, T> dictReverse = new SortedDictionary<string, T>();

		public static void Add(T enumeration, EFTConstant<string> value)
		{
			EFTProperties<T>.dict.Add(enumeration, value);
			EFTProperties<T>.dictReverse.Add(value.Value, enumeration);
		}

		public static EFTConstant<string> Value(T enumeration)
		{
			EFTConstant<string> result;
			try
			{
				result = EFTProperties<T>.dict[enumeration];
			}
			catch (Exception innerException)
			{
				throw new InvalidCastException(string.Format("Invalid value [{0}] for this enumeration", Convert.ToInt32(enumeration).ToString()), innerException);
			}
			return result;
		}

		public static T Enum(string value)
		{
			T result;
			try
			{
				result = EFTProperties<T>.dictReverse[value];
			}
			catch (Exception innerException)
			{
				throw new InvalidCastException(string.Format("Invalid value [{0}] for this enumeration", value), innerException);
			}
			return result;
		}
	}
}
