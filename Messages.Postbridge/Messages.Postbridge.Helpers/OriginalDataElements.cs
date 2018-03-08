using System;

namespace Messages.Postbridge.Helpers
{
	public class OriginalDataElements
	{
		public string OriginalMessageType
		{
			get;
			set;
		}

		public string OriginalSystemsTraceAuditNumber
		{
			get;
			set;
		}

		public string OriginalTransmissionDateAndTime
		{
			get;
			set;
		}

		public string OriginalAcquirerInstitutionID
		{
			get;
			set;
		}

		public string OriginalForwardingInstitutionID
		{
			get;
			set;
		}

		public OriginalDataElements(string originalMessageType, string originalSystemsTraceAuditNumber, string originalTransmissionDateAndTime, string originalAcquirerInstitutionID, string originalForwardingInstitutionID)
		{
			this.OriginalMessageType = originalMessageType;
			this.OriginalSystemsTraceAuditNumber = originalSystemsTraceAuditNumber;
			this.OriginalTransmissionDateAndTime = originalTransmissionDateAndTime;
			this.OriginalAcquirerInstitutionID = originalAcquirerInstitutionID;
			this.OriginalForwardingInstitutionID = originalForwardingInstitutionID;
		}

		public OriginalDataElements(string originalDataElements)
		{
			this.OriginalMessageType = originalDataElements.Substring(0, 4);
			this.OriginalSystemsTraceAuditNumber = originalDataElements.Substring(4, 6);
			this.OriginalTransmissionDateAndTime = originalDataElements.Substring(10, 10);
			this.OriginalAcquirerInstitutionID = originalDataElements.Substring(20, 11);
			this.OriginalForwardingInstitutionID = originalDataElements.Substring(31, 11);
		}

		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.OriginalMessageType,
				this.OriginalSystemsTraceAuditNumber,
				this.OriginalTransmissionDateAndTime,
				this.OriginalAcquirerInstitutionID,
				this.OriginalForwardingInstitutionID
			});
		}

		public static OriginalDataElements FromString(string originalDataElements)
		{
			return new OriginalDataElements(originalDataElements);
		}
	}
}
