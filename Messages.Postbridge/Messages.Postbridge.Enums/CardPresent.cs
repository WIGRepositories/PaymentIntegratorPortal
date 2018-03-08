using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class CardPresent : EFTProperties<CardPresentEnum>
	{
		public static EFTConstant<string> CardNotPresent;

		public static EFTConstant<string> CardIsPresent;

		static CardPresent()
		{
			CardPresent.CardNotPresent = new EFTConstant<string>("0");
			CardPresent.CardIsPresent = new EFTConstant<string>("1");
			EFTProperties<CardPresentEnum>.Add(CardPresentEnum.CardNotPresent, CardPresent.CardNotPresent);
			EFTProperties<CardPresentEnum>.Add(CardPresentEnum.CardPresent, CardPresent.CardIsPresent);
		}
	}
}
