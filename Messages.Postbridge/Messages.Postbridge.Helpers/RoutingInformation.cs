using System;

namespace Messages.Postbridge.Helpers
{
	public class RoutingInformation
	{
		public string SourceNode
		{
			get;
			set;
		}

		public string SinkNode
		{
			get;
			set;
		}

		public string SourceNodeSystemsTraceAuditNumber
		{
			get;
			set;
		}

		public string SinkNodeSystemsTraceAuditNumber
		{
			get;
			set;
		}

		public string TotalsGroup
		{
			get;
			set;
		}

		public RoutingInformation(string sourceNode, string sinkNode, string sourceNodeSystemsTraceAuditNumber, string sinkNodeSystemsTraceAuditNumber, string totalsGroup)
		{
			this.InitStrings(sourceNode, sinkNode, sourceNodeSystemsTraceAuditNumber, sinkNodeSystemsTraceAuditNumber, totalsGroup);
		}

		public RoutingInformation(string routingInfo)
		{
			this.InitStrings(routingInfo.Substring(0, 12), routingInfo.Substring(12, 12), routingInfo.Substring(24, 6), routingInfo.Substring(30, 6), routingInfo.Substring(36, 12));
		}

		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.SourceNode,
				this.SinkNode,
				this.SourceNodeSystemsTraceAuditNumber,
				this.SinkNodeSystemsTraceAuditNumber,
				this.TotalsGroup
			});
		}

		public static RoutingInformation FromString(string routingInfo)
		{
			return new RoutingInformation(routingInfo);
		}

		private void InitStrings(string sourceNode, string sinkNode, string sourceNodeSystemsTraceAuditNumber, string sinkNodeSystemsTraceAuditNumber, string totalsGroup)
		{
			this.SourceNode = sourceNode;
			this.SinkNode = sinkNode;
			this.SourceNodeSystemsTraceAuditNumber = sourceNodeSystemsTraceAuditNumber;
			this.SinkNodeSystemsTraceAuditNumber = sinkNodeSystemsTraceAuditNumber;
			this.TotalsGroup = totalsGroup;
		}
	}
}
