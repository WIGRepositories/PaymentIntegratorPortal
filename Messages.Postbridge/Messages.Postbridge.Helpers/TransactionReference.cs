using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Messages.Postbridge.Helpers
{
	public class TransactionReference
	{
		private const string MATCHING = "M";

		private const string ORIGINAL = "O";

		private Dictionary<string, StructuredDataItem> DataItems;

		public TransactionReference()
		{
			this.DataItems = new Dictionary<string, StructuredDataItem>();
		}

		public TransactionReference(string tranReference)
		{
			using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(tranReference)))
			{
				this.Init(memoryStream);
			}
		}

		public TransactionReference(Stream stream)
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

		public static TransactionReference FromString(string tranReference)
		{
			return new TransactionReference(tranReference);
		}

		public int GetMatchingReferenceCount()
		{
			return this.GetMatchingItemCount("M");
		}

		public int GetOriginalReferenceCount()
		{
			return this.GetMatchingItemCount("O");
		}

		public string GetMatchingReference(int index)
		{
			return this.GetMatchingItem(index, "M");
		}

		public string GetOriginalReference(int index)
		{
			return this.GetMatchingItem(index, "O");
		}

		public void Clear()
		{
			this.DataItems.Clear();
		}

		public void AddMatchingReference(string value)
		{
			int matchingReferenceCount = this.GetMatchingReferenceCount();
			this.DataItems.Add("M" + matchingReferenceCount.ToString(), new StructuredDataItem("M" + matchingReferenceCount.ToString(), value));
		}

		public void AddOriginalReference(string value)
		{
			int matchingReferenceCount = this.GetMatchingReferenceCount();
			this.DataItems.Add("O" + matchingReferenceCount.ToString(), new StructuredDataItem("O" + matchingReferenceCount.ToString(), value));
		}

		private string GetMatchingItem(int index, string starting)
		{
			string key = starting + index.ToString();
			return this.DataItems[key].Value;
		}

		private int GetMatchingItemCount(string starting)
		{
			int num = 0;
			foreach (string current in this.DataItems.Keys)
			{
				if (current.StartsWith(starting))
				{
					num++;
				}
			}
			return num;
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
