using Messages.Core.Field;
using Messages.Postbridge.Helpers;
using System;
using System.Text;

namespace Messages.Postbridge.Fields
{
	public class TransactionReference : Empty
	{
		public Messages.Postbridge.Helpers.TransactionReference TranReference
		{
			get
			{
				return Messages.Postbridge.Helpers.TransactionReference.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public override string Describe()
		{
			Messages.Postbridge.Helpers.TransactionReference tranReference = this.TranReference;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("[Transaction Reference\r\n\r\n");
			for (int i = 0; i < tranReference.GetMatchingReferenceCount(); i++)
			{
				stringBuilder.Append(string.Format("   Match ref #[{0}]\r\n", i.ToString()));
				stringBuilder.Append(string.Format("   Data[{0}]\r\n", tranReference.GetMatchingReference(i)));
			}
			for (int j = 0; j < tranReference.GetOriginalReferenceCount(); j++)
			{
				stringBuilder.Append(string.Format("   Orig ref #[{0}]\r\n", j.ToString()));
				stringBuilder.Append(string.Format("   Data[{0}]\r\n", tranReference.GetOriginalReference(j)));
			}
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}
	}
}
