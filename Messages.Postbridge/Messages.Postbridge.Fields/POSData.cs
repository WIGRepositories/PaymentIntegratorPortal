using Messages.Core.Field;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class POSData : Empty
	{
		public Messages.Postbridge.Helpers.POSData Data
		{
			get
			{
				return Messages.Postbridge.Helpers.POSData.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public string POSTerminalID
		{
			get
			{
				return this.Data.POSTerminalID;
			}
			set
			{
				Messages.Postbridge.Helpers.POSData data = this.Data;
				data.POSOperatorID = value;
				this.Data = data;
			}
		}

		public string POSOperatorID
		{
			get
			{
				return this.Data.POSOperatorID;
			}
			set
			{
				Messages.Postbridge.Helpers.POSData data = this.Data;
				data.POSOperatorID = value;
				this.Data = data;
			}
		}

		public string POSSequenceNumber
		{
			get
			{
				return this.Data.POSSequenceNumber;
			}
			set
			{
				Messages.Postbridge.Helpers.POSData data = this.Data;
				data.POSSequenceNumber = value;
				this.Data = data;
			}
		}
	}
}
