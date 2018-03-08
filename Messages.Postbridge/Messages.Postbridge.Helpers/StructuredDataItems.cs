using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Messages.Postbridge.Helpers
{
	public class StructuredDataItems
	{
		public Dictionary<string, StructuredDataItem> DataItems;

		public StructuredDataItems()
		{
			this.DataItems = new Dictionary<string, StructuredDataItem>();
		}

		public StructuredDataItems(string structuredData)
		{
			using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(structuredData)))
			{
				this.Init(memoryStream);
			}
		}

		public StructuredDataItems(Stream stream)
		{
			this.Init(stream);
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string current in this.DataItems.Keys)
			{
				stringBuilder.Append(this.DataItems[current].ToString());
			}
			return stringBuilder.ToString();
		}

		public static StructuredDataItems FromString(string structuredData)
		{
			return new StructuredDataItems(structuredData);
		}

		private void Init(Stream stream)
		{
			this.DataItems = new Dictionary<string, StructuredDataItem>();
			while (stream.Position < stream.Length)
			{
				StructuredDataItem structuredDataItem = new StructuredDataItem(stream);
				this.DataItems.Add(structuredDataItem.Key, structuredDataItem);
			}
		}
	}
}
