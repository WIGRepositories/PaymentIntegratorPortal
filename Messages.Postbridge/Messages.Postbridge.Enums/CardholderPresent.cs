using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class CardholderPresent : EFTProperties<CardholderPresentEnum>
	{
		public static EFTConstant<string> CardholderIsPresent;

		public static EFTConstant<string> CardholderNotPresentUnspecified;

		public static EFTConstant<string> CardholderNotPresentMailOrder;

		public static EFTConstant<string> CardholderNotPresentTelephone;

		public static EFTConstant<string> CardholderNotPresentStandingAuthorization;

		public static EFTConstant<string> CardholderNotPresentElectronicOrder;

		static CardholderPresent()
		{
			CardholderPresent.CardholderIsPresent = new EFTConstant<string>("0");
			CardholderPresent.CardholderNotPresentUnspecified = new EFTConstant<string>("1");
			CardholderPresent.CardholderNotPresentMailOrder = new EFTConstant<string>("2");
			CardholderPresent.CardholderNotPresentTelephone = new EFTConstant<string>("3");
			CardholderPresent.CardholderNotPresentStandingAuthorization = new EFTConstant<string>("4");
			CardholderPresent.CardholderNotPresentElectronicOrder = new EFTConstant<string>("5");
			EFTProperties<CardholderPresentEnum>.Add(CardholderPresentEnum.CardholderNotPresentElectronicOrder, CardholderPresent.CardholderNotPresentElectronicOrder);
			EFTProperties<CardholderPresentEnum>.Add(CardholderPresentEnum.CardholderNotPresentMailOrder, CardholderPresent.CardholderNotPresentMailOrder);
			EFTProperties<CardholderPresentEnum>.Add(CardholderPresentEnum.CardholderNotPresentStandingAuthorization, CardholderPresent.CardholderNotPresentStandingAuthorization);
			EFTProperties<CardholderPresentEnum>.Add(CardholderPresentEnum.CardholderNotPresentTelephone, CardholderPresent.CardholderNotPresentTelephone);
			EFTProperties<CardholderPresentEnum>.Add(CardholderPresentEnum.CardholderNotPresentUnspecified, CardholderPresent.CardholderNotPresentUnspecified);
			EFTProperties<CardholderPresentEnum>.Add(CardholderPresentEnum.CardholderPresent, CardholderPresent.CardholderIsPresent);
		}
	}
}
