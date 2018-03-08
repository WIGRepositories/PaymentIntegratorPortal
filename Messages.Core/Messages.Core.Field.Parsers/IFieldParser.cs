using System;
using System.IO;

namespace Messages.Core.Field.Parsers
{
	public interface IFieldParser
	{
		string Parse(IField field, string content);

		string Parse(IField field, Stream stream);

		byte[] ByteParse(IField field, Stream stream);
	}
}
