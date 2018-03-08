using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class NetworkManagementCode : Empty
	{
		public NetworkManagementCodeEnum Code
		{
			get
			{
				return EFTProperties<NetworkManagementCodeEnum>.Enum(base.Content);
			}
			set
			{
				base.Content = EFTProperties<NetworkManagementCodeEnum>.Value(value).Value;
			}
		}
	}
}
