using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class OperatingEnvironment : EFTProperties<OperatingEnvironmentEnum>
	{
		public static EFTConstant<string> NoTerminalUsed;

		public static EFTConstant<string> OnPremisesOfCardAcceptorAttended;

		public static EFTConstant<string> OnPremisesOfCardAcceptorUnattended;

		public static EFTConstant<string> OffPremisesOfCardAcceptorAttended;

		public static EFTConstant<string> OffPremisesOfCardAcceptorUnattended;

		public static EFTConstant<string> OnPremisesOfCardHolderUnattended;

		static OperatingEnvironment()
		{
			OperatingEnvironment.NoTerminalUsed = new EFTConstant<string>("0");
			OperatingEnvironment.OnPremisesOfCardAcceptorAttended = new EFTConstant<string>("1");
			OperatingEnvironment.OnPremisesOfCardAcceptorUnattended = new EFTConstant<string>("2");
			OperatingEnvironment.OffPremisesOfCardAcceptorAttended = new EFTConstant<string>("3");
			OperatingEnvironment.OffPremisesOfCardAcceptorUnattended = new EFTConstant<string>("4");
			OperatingEnvironment.OnPremisesOfCardHolderUnattended = new EFTConstant<string>("5");
			EFTProperties<OperatingEnvironmentEnum>.Add(OperatingEnvironmentEnum.NoTerminalUsed, OperatingEnvironment.NoTerminalUsed);
			EFTProperties<OperatingEnvironmentEnum>.Add(OperatingEnvironmentEnum.OffPremisesOfCardAcceptorAttended, OperatingEnvironment.OffPremisesOfCardAcceptorAttended);
			EFTProperties<OperatingEnvironmentEnum>.Add(OperatingEnvironmentEnum.OffPremisesOfCardAcceptorUnattended, OperatingEnvironment.OffPremisesOfCardAcceptorUnattended);
			EFTProperties<OperatingEnvironmentEnum>.Add(OperatingEnvironmentEnum.OnPremisesOfCardAcceptorAttended, OperatingEnvironment.OnPremisesOfCardAcceptorAttended);
			EFTProperties<OperatingEnvironmentEnum>.Add(OperatingEnvironmentEnum.OnPremisesOfCardAcceptorUnattended, OperatingEnvironment.OnPremisesOfCardAcceptorUnattended);
			EFTProperties<OperatingEnvironmentEnum>.Add(OperatingEnvironmentEnum.OnPremisesOfCardHolderUnattended, OperatingEnvironment.OnPremisesOfCardHolderUnattended);
		}
	}
}
