using Messages.Core.Field;
using Messages.Postbridge.Helpers;
using System;
using System.Text;

namespace Messages.Postbridge.Fields
{
	public class StructuredData : Empty
	{
		public StructuredDataItems StructData
		{
			get
			{
				return StructuredDataItems.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public override string Describe()
		{
			StructuredDataItems structData = this.StructData;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("[Structured Data\r\n\r\n");
			foreach (string current in structData.DataItems.Keys)
			{
				stringBuilder.Append(string.Format("   Key [{0}]\r\n", current));
				stringBuilder.Append(string.Format("   Data[{0}]\r\n", structData.DataItems[current].Value));
			}
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}
	}
}
