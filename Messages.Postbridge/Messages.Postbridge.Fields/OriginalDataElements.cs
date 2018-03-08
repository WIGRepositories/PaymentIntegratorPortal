using Messages.Core.Field;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class OriginalDataElements : Empty
	{
		public Messages.Postbridge.Helpers.OriginalDataElements DataElements
		{
			get
			{
				return Messages.Postbridge.Helpers.OriginalDataElements.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public string OriginalAcquirerInstitutionID
		{
			get
			{
				return this.DataElements.OriginalAcquirerInstitutionID;
			}
			set
			{
				Messages.Postbridge.Helpers.OriginalDataElements dataElements = this.DataElements;
				dataElements.OriginalAcquirerInstitutionID = value;
				this.DataElements = dataElements;
			}
		}

		public string OriginalForwardingInstitutionID
		{
			get
			{
				return this.DataElements.OriginalForwardingInstitutionID;
			}
			set
			{
				Messages.Postbridge.Helpers.OriginalDataElements dataElements = this.DataElements;
				dataElements.OriginalForwardingInstitutionID = value;
				this.DataElements = dataElements;
			}
		}

		public string OriginalMessageType
		{
			get
			{
				return this.DataElements.OriginalMessageType;
			}
			set
			{
				Messages.Postbridge.Helpers.OriginalDataElements dataElements = this.DataElements;
				dataElements.OriginalMessageType = value;
				this.DataElements = dataElements;
			}
		}

		public string OriginalSystemsTraceAuditNumber
		{
			get
			{
				return this.DataElements.OriginalSystemsTraceAuditNumber;
			}
			set
			{
				Messages.Postbridge.Helpers.OriginalDataElements dataElements = this.DataElements;
				dataElements.OriginalSystemsTraceAuditNumber = value;
				this.DataElements = dataElements;
			}
		}

		public string OriginalTransmissionDateAndTime
		{
			get
			{
				return this.DataElements.OriginalTransmissionDateAndTime;
			}
			set
			{
				Messages.Postbridge.Helpers.OriginalDataElements dataElements = this.DataElements;
				dataElements.OriginalTransmissionDateAndTime = value;
				this.DataElements = dataElements;
			}
		}
	}
}
