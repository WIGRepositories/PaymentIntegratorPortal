using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class TerminalOperator : EFTProperties<TerminalOperatorEnum>
	{
		public static EFTConstant<string> CustomerOperated;

		public static EFTConstant<string> CardAcceptorOperated;

		public static EFTConstant<string> Administrative;

		static TerminalOperator()
		{
			TerminalOperator.CustomerOperated = new EFTConstant<string>("0");
			TerminalOperator.CardAcceptorOperated = new EFTConstant<string>("1");
			TerminalOperator.Administrative = new EFTConstant<string>("2");
			EFTProperties<TerminalOperatorEnum>.Add(TerminalOperatorEnum.Administrative, TerminalOperator.Administrative);
			EFTProperties<TerminalOperatorEnum>.Add(TerminalOperatorEnum.CardAcceptorOperated, TerminalOperator.CardAcceptorOperated);
			EFTProperties<TerminalOperatorEnum>.Add(TerminalOperatorEnum.CustomerOperated, TerminalOperator.CustomerOperated);
		}
	}
}
