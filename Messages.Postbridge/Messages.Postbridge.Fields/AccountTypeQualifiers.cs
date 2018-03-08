using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class AccountTypeQualifiers : Empty
	{
		public Messages.Postbridge.Helpers.AccountTypeQualifiers Qualifiers
		{
			get
			{
				return new Messages.Postbridge.Helpers.AccountTypeQualifiers(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public AccountTypeQualifierEnum FromAccount
		{
			get
			{
				return this.Qualifiers.FromAccount;
			}
			set
			{
				Messages.Postbridge.Helpers.AccountTypeQualifiers qualifiers = this.Qualifiers;
				qualifiers.FromAccount = value;
				this.Qualifiers = qualifiers;
			}
		}

		public AccountTypeQualifierEnum ToAccount
		{
			get
			{
				return this.Qualifiers.ToAccount;
			}
			set
			{
				Messages.Postbridge.Helpers.AccountTypeQualifiers qualifiers = this.Qualifiers;
				qualifiers.ToAccount = value;
				this.Qualifiers = qualifiers;
			}
		}
	}
}
