using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class CardholderAuthenticationEntity : EFTProperties<CardholderAuthenticationEntityEnum>
	{
		public static EFTConstant<string> NotAuthenticated;

		public static EFTConstant<string> ICC;

		public static EFTConstant<string> Terminal;

		public static EFTConstant<string> AuthorizingAgent;

		public static EFTConstant<string> Merchant;

		public static EFTConstant<string> Other;

		static CardholderAuthenticationEntity()
		{
			CardholderAuthenticationEntity.NotAuthenticated = new EFTConstant<string>("0");
			CardholderAuthenticationEntity.ICC = new EFTConstant<string>("1");
			CardholderAuthenticationEntity.Terminal = new EFTConstant<string>("2");
			CardholderAuthenticationEntity.AuthorizingAgent = new EFTConstant<string>("3");
			CardholderAuthenticationEntity.Merchant = new EFTConstant<string>("4");
			CardholderAuthenticationEntity.Other = new EFTConstant<string>("5");
			EFTProperties<CardholderAuthenticationEntityEnum>.Add(CardholderAuthenticationEntityEnum.AuthorizingAgent, CardholderAuthenticationEntity.AuthorizingAgent);
			EFTProperties<CardholderAuthenticationEntityEnum>.Add(CardholderAuthenticationEntityEnum.ICC, CardholderAuthenticationEntity.ICC);
			EFTProperties<CardholderAuthenticationEntityEnum>.Add(CardholderAuthenticationEntityEnum.Merchant, CardholderAuthenticationEntity.Merchant);
			EFTProperties<CardholderAuthenticationEntityEnum>.Add(CardholderAuthenticationEntityEnum.NotAuthenticated, CardholderAuthenticationEntity.NotAuthenticated);
			EFTProperties<CardholderAuthenticationEntityEnum>.Add(CardholderAuthenticationEntityEnum.Other, CardholderAuthenticationEntity.Other);
			EFTProperties<CardholderAuthenticationEntityEnum>.Add(CardholderAuthenticationEntityEnum.Terminal, CardholderAuthenticationEntity.Terminal);
		}
	}
}
