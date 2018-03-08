using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class POSDataCode : Empty
	{
		public Messages.Postbridge.Helpers.POSDataCode DataCode
		{
			get
			{
				return new Messages.Postbridge.Helpers.POSDataCode(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public CardCaptureCapabilityEnum CardCaptureCapability
		{
			get
			{
				return this.DataCode.CardCaptureCapability;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.CardCaptureCapability = value;
				this.DataCode = dataCode;
			}
		}

		public CardDataInputCapabilityEnum CardDataInputCapability
		{
			get
			{
				return this.DataCode.CardDataInputCapability;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.CardDataInputCapability = value;
				this.DataCode = dataCode;
			}
		}

		public CardDataInputModeEnum CardDataInputMode
		{
			get
			{
				return this.DataCode.CardDataInputMode;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.CardDataInputMode = value;
				this.DataCode = dataCode;
			}
		}

		public CardDataOutputCapabilityEnum CardDataOutputCapability
		{
			get
			{
				return this.DataCode.CardDataOutputCapability;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.CardDataOutputCapability = value;
				this.DataCode = dataCode;
			}
		}

		public CardholderAuthenticationCapabilityEnum CardholderAuthenticationCapability
		{
			get
			{
				return this.DataCode.CardholderAuthenticationCapability;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.CardholderAuthenticationCapability = value;
				this.DataCode = dataCode;
			}
		}

		public CardholderAuthenticationEntityEnum CardholderAuthenticationEntity
		{
			get
			{
				return this.DataCode.CardholderAuthenticationEntity;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.CardholderAuthenticationEntity = value;
				this.DataCode = dataCode;
			}
		}

		public CardholderAuthenticationMethodEnum CardholderAuthenticationMethod
		{
			get
			{
				return this.DataCode.CardholderAuthenticationMethod;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.CardholderAuthenticationMethod = value;
				this.DataCode = dataCode;
			}
		}

		public CardholderPresentEnum CardholderPresent
		{
			get
			{
				return this.DataCode.CardholderPresent;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.CardholderPresent = value;
				this.DataCode = dataCode;
			}
		}

		public CardPresentEnum CardPresent
		{
			get
			{
				return this.DataCode.CardPresent;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.CardPresent = value;
				this.DataCode = dataCode;
			}
		}

		public OperatingEnvironmentEnum OperatingEnvironment
		{
			get
			{
				return this.DataCode.OperatingEnvironment;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.OperatingEnvironment = value;
				this.DataCode = dataCode;
			}
		}

		public PINCaptureCapabilityEnum PINCaptureCapability
		{
			get
			{
				return this.DataCode.PINCaptureCapability;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.PINCaptureCapability = value;
				this.DataCode = dataCode;
			}
		}

		public TerminalOperatorEnum TerminalOperator
		{
			get
			{
				return this.DataCode.TerminalOperator;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.TerminalOperator = value;
				this.DataCode = dataCode;
			}
		}

		public TerminalOutputCapabilityEnum TerminalOutputCapability
		{
			get
			{
				return this.DataCode.TerminalOutputCapability;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.TerminalOutputCapability = value;
				this.DataCode = dataCode;
			}
		}

		public TerminalTypeEnum TerminalType
		{
			get
			{
				return this.DataCode.TerminalType;
			}
			set
			{
				Messages.Postbridge.Helpers.POSDataCode dataCode = this.DataCode;
				dataCode.TerminalType = value;
				this.DataCode = dataCode;
			}
		}
	}
}
