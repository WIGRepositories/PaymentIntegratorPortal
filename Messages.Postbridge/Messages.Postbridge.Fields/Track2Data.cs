using Messages.Core.Field;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class Track2Data : Empty
	{
		public Messages.Postbridge.Helpers.Track2Data T2Data
		{
			get
			{
				return Messages.Postbridge.Helpers.Track2Data.FromString(base.Content);
			}
		}
	}
}
