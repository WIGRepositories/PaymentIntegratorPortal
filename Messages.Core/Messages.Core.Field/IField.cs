using Messages.Core.Field.Formatters;
using Messages.Core.Field.Parsers;
using Messages.Core.Field.Validators;
using System;
using System.Collections.Generic;
using System.IO;

namespace Messages.Core.Field
{
	public interface IField
	{
		string Name
		{
			get;
			set;
		}

		int Size
		{
			get;
			set;
		}

		int Number
		{
			get;
			set;
		}

		FieldLength Length
		{
			get;
			set;
		}

		FieldFormat Format
		{
			get;
			set;
		}

		string Content
		{
			get;
			set;
		}

		byte[] Bytes
		{
			get;
			set;
		}

		IFieldFormatter Formatter
		{
			get;
			set;
		}

		IFieldValidator Validator
		{
			get;
			set;
		}

		IFieldParser Parser
		{
			get;
			set;
		}

		SortedList<int, IField> Subfields
		{
			get;
			set;
		}

		IField Parent
		{
			get;
			set;
		}

		IField AddSubfield(IField field);

		bool IsSet();

		void Decode(Stream stream);

		void Encode(Stream stream);

		string Describe();

		void AfterDecode();

		void BeforeEncode();

		IField Copy();
	}
}
