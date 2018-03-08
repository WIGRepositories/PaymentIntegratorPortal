using Messages.Core.Field;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class RoutingInformation : Empty
	{
		public Messages.Postbridge.Helpers.RoutingInformation RoutingInfo
		{
			get
			{
				return new Messages.Postbridge.Helpers.RoutingInformation(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public string SourceNode
		{
			get
			{
				return this.RoutingInfo.SourceNode;
			}
			set
			{
				Messages.Postbridge.Helpers.RoutingInformation routingInfo = this.RoutingInfo;
				routingInfo.SourceNode = value;
				this.RoutingInfo = routingInfo;
			}
		}

		public string SinkNode
		{
			get
			{
				return this.RoutingInfo.SinkNode;
			}
			set
			{
				Messages.Postbridge.Helpers.RoutingInformation routingInfo = this.RoutingInfo;
				routingInfo.SinkNode = value;
				this.RoutingInfo = routingInfo;
			}
		}

		public string SinkNodeSystemsTraceAuditNumber
		{
			get
			{
				return this.RoutingInfo.SinkNodeSystemsTraceAuditNumber;
			}
			set
			{
				Messages.Postbridge.Helpers.RoutingInformation routingInfo = this.RoutingInfo;
				routingInfo.SinkNodeSystemsTraceAuditNumber = value;
				this.RoutingInfo = routingInfo;
			}
		}

		public string SourceNodeSystemsTraceAuditNumber
		{
			get
			{
				return this.RoutingInfo.SourceNodeSystemsTraceAuditNumber;
			}
			set
			{
				Messages.Postbridge.Helpers.RoutingInformation routingInfo = this.RoutingInfo;
				routingInfo.SourceNodeSystemsTraceAuditNumber = value;
				this.RoutingInfo = routingInfo;
			}
		}

		public string TotalsGroup
		{
			get
			{
				return this.RoutingInfo.TotalsGroup;
			}
			set
			{
				Messages.Postbridge.Helpers.RoutingInformation routingInfo = this.RoutingInfo;
				routingInfo.TotalsGroup = value;
				this.RoutingInfo = routingInfo;
			}
		}
	}
}
