using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class FileUpdateCode : Empty
	{
		public FileUpdateCodeEnum Code
		{
			get
			{
				return EFTProperties<FileUpdateCodeEnum>.Enum(base.Content);
			}
			set
			{
				base.Content = EFTProperties<FileUpdateCodeEnum>.Value(value).Value;
			}
		}
	}
}
