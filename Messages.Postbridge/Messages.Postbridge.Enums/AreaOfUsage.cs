using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class AreaOfUsage : EFTProperties<AreaOfUsageEnum>
	{
		public static EFTConstant<string> Reserved;

		public static EFTConstant<string> InternationalCard;

		public static EFTConstant<string> InternationalCardICC;

		public static EFTConstant<string> Reserved2;

		public static EFTConstant<string> Reserved3;

		public static EFTConstant<string> NationalUseOnly;

		public static EFTConstant<string> NationalUseOnlyICC;

		public static EFTConstant<string> Reserved4;

		public static EFTConstant<string> Reserved5;

		public static EFTConstant<string> TestCard;

		static AreaOfUsage()
		{
			AreaOfUsage.Reserved = new EFTConstant<string>("0");
			AreaOfUsage.InternationalCard = new EFTConstant<string>("1");
			AreaOfUsage.InternationalCardICC = new EFTConstant<string>("2");
			AreaOfUsage.Reserved2 = new EFTConstant<string>("3");
			AreaOfUsage.Reserved3 = new EFTConstant<string>("4");
			AreaOfUsage.NationalUseOnly = new EFTConstant<string>("5");
			AreaOfUsage.NationalUseOnlyICC = new EFTConstant<string>("6");
			AreaOfUsage.Reserved4 = new EFTConstant<string>("7");
			AreaOfUsage.Reserved5 = new EFTConstant<string>("8");
			AreaOfUsage.TestCard = new EFTConstant<string>("9");
			EFTProperties<AreaOfUsageEnum>.Add(AreaOfUsageEnum.Reserved, AreaOfUsage.Reserved);
			EFTProperties<AreaOfUsageEnum>.Add(AreaOfUsageEnum.Reserved2, AreaOfUsage.Reserved2);
			EFTProperties<AreaOfUsageEnum>.Add(AreaOfUsageEnum.Reserved3, AreaOfUsage.Reserved3);
			EFTProperties<AreaOfUsageEnum>.Add(AreaOfUsageEnum.Reserved4, AreaOfUsage.Reserved4);
			EFTProperties<AreaOfUsageEnum>.Add(AreaOfUsageEnum.Reserved5, AreaOfUsage.Reserved5);
			EFTProperties<AreaOfUsageEnum>.Add(AreaOfUsageEnum.InternationalCard, AreaOfUsage.InternationalCard);
			EFTProperties<AreaOfUsageEnum>.Add(AreaOfUsageEnum.InternationalCardICC, AreaOfUsage.InternationalCardICC);
			EFTProperties<AreaOfUsageEnum>.Add(AreaOfUsageEnum.NationalUseOnly, AreaOfUsage.NationalUseOnly);
			EFTProperties<AreaOfUsageEnum>.Add(AreaOfUsageEnum.NationalUseOnlyICC, AreaOfUsage.NationalUseOnlyICC);
			EFTProperties<AreaOfUsageEnum>.Add(AreaOfUsageEnum.TestCard, AreaOfUsage.TestCard);
		}
	}
}
