using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class MessageType : Empty
	{
		public MessageTypeEnum Code
		{
			get
			{
				return EFTProperties<MessageTypeEnum>.Enum(base.Content);
			}
			set
			{
				base.Content = EFTProperties<MessageTypeEnum>.Value(value).Value;
			}
		}
	}
}
