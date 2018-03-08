using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class CardVerificationResult : Empty
	{
		public CardVerificationResultEnum Result
		{
			get
			{
				return EFTProperties<CardVerificationResultEnum>.Enum(base.Content);
			}
			set
			{
				base.Content = EFTProperties<CardVerificationResultEnum>.Value(value).Value;
			}
		}
	}
}
