using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class ProcessingCode : Empty
	{
		public Messages.Postbridge.Helpers.ProcessingCode Code
		{
			get
			{
				return Messages.Postbridge.Helpers.ProcessingCode.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public TransactionTypeEnum TransactionType
		{
			get
			{
				return this.Code.TransactionType;
			}
			set
			{
				Messages.Postbridge.Helpers.ProcessingCode code = this.Code;
				code.TransactionType = value;
				this.Code = code;
			}
		}

		public AccountTypeEnum FromAccount
		{
			get
			{
				return this.Code.FromAccount;
			}
			set
			{
				Messages.Postbridge.Helpers.ProcessingCode code = this.Code;
				code.FromAccount = value;
				this.Code = code;
			}
		}

		public AccountTypeEnum ToAccount
		{
			get
			{
				return this.Code.ToAccount;
			}
			set
			{
				Messages.Postbridge.Helpers.ProcessingCode code = this.Code;
				code.ToAccount = value;
				this.Code = code;
			}
		}
	}
}
