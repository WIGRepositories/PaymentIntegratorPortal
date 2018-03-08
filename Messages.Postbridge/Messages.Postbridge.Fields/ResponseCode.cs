using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class ResponseCode : Empty
	{
		public ResponseCodeEnum Code
		{
			get
			{
				return EFTProperties<ResponseCodeEnum>.Enum(base.Content);
			}
			set
			{
				base.Content = EFTProperties<ResponseCodeEnum>.Value(value).Value;
			}
		}
	}
}
