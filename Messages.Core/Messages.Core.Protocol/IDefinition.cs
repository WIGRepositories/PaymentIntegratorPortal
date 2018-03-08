using Messages.Core.Field;
using System;
using System.Collections.Generic;

namespace Messages.Core.Protocol
{
	public interface IDefinition
	{
		string Name
		{
			get;
			set;
		}

		SortedList<int, IField> Fields
		{
			get;
		}

		IDefinition AddField(IField field);

		void WriteXML(string fileName);

		void ReadXML(string fileName);
	}
}
