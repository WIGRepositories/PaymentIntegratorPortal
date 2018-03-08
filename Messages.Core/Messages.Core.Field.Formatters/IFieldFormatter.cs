using System;
using System.IO;

namespace Messages.Core.Field.Formatters
{
	public interface IFieldFormatter
	{
		string Format(string content);

		void Format(string content, Stream stream);

		string Format(byte[] content);

		void Format(byte[] content, Stream stream);
	}
}
