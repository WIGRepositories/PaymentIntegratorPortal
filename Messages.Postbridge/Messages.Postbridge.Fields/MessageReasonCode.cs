using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class MessageReasonCode : Empty
	{
		public MessageReasonCodeEnum ReasonCode
		{
			get
			{
				return EFTProperties<MessageReasonCodeEnum>.Enum(base.Content);
			}
			set
			{
				base.Content = EFTProperties<MessageReasonCodeEnum>.Value(value).Value;
			}
		}
	}
}
