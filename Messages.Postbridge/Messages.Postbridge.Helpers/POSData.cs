using System;

namespace Messages.Postbridge.Helpers
{
	public class POSData
	{
		public string POSTerminalID
		{
			get;
			set;
		}

		public string POSSequenceNumber
		{
			get;
			set;
		}

		public string POSOperatorID
		{
			get;
			set;
		}

		public POSData(string posTerminalID, string posSequenceNumber, string posOperatorID)
		{
			this.InitStrings(posTerminalID, posSequenceNumber, posOperatorID);
		}

		public POSData(string posData)
		{
			this.InitStrings(posData.Substring(0, 8), posData.Substring(8, 6), posData.Substring(14, 8));
		}

		public override string ToString()
		{
			return this.POSTerminalID + this.POSSequenceNumber + this.POSOperatorID;
		}

		public static POSData FromString(string posData)
		{
			return new POSData(posData);
		}

		private void InitStrings(string posTerminalID, string posSequenceNumber, string posOperatorID)
		{
			this.POSTerminalID = posTerminalID;
			this.POSSequenceNumber = posSequenceNumber;
			this.POSOperatorID = posOperatorID;
		}
	}
}
