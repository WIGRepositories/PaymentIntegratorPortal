using Messages.Postbridge.Enums;
using System;

namespace Messages.Postbridge.Helpers
{
	public class POSDataCode
	{
		public CardDataInputCapabilityEnum CardDataInputCapability
		{
			get;
			set;
		}

		public CardholderAuthenticationCapabilityEnum CardholderAuthenticationCapability
		{
			get;
			set;
		}

		public CardCaptureCapabilityEnum CardCaptureCapability
		{
			get;
			set;
		}

		public OperatingEnvironmentEnum OperatingEnvironment
		{
			get;
			set;
		}

		public CardholderPresentEnum CardholderPresent
		{
			get;
			set;
		}

		public CardPresentEnum CardPresent
		{
			get;
			set;
		}

		public CardDataInputModeEnum CardDataInputMode
		{
			get;
			set;
		}

		public CardholderAuthenticationMethodEnum CardholderAuthenticationMethod
		{
			get;
			set;
		}

		public CardholderAuthenticationEntityEnum CardholderAuthenticationEntity
		{
			get;
			set;
		}

		public CardDataOutputCapabilityEnum CardDataOutputCapability
		{
			get;
			set;
		}

		public TerminalOutputCapabilityEnum TerminalOutputCapability
		{
			get;
			set;
		}

		public PINCaptureCapabilityEnum PINCaptureCapability
		{
			get;
			set;
		}

		public TerminalOperatorEnum TerminalOperator
		{
			get;
			set;
		}

		public TerminalTypeEnum TerminalType
		{
			get;
			set;
		}

		public POSDataCode(CardDataInputCapabilityEnum cardDataInputCapability, CardholderAuthenticationCapabilityEnum cardholderAuthenticationCapability, CardCaptureCapabilityEnum cardCaptureCapability, OperatingEnvironmentEnum operatingEnvironment, CardholderPresentEnum cardholderPresent, CardPresentEnum cardPresent, CardDataInputModeEnum cardDataInputMode, CardholderAuthenticationMethodEnum cardholderAuthenticationMethod, CardholderAuthenticationEntityEnum cardholderAuthenticationEntity, CardDataOutputCapabilityEnum cardDataOutputCapability, TerminalOutputCapabilityEnum terminalOutputCapability, PINCaptureCapabilityEnum pINCaptureCapability, TerminalOperatorEnum terminalOperator, TerminalTypeEnum terminalType)
		{
			this.CardDataInputCapability = cardDataInputCapability;
			this.CardholderAuthenticationCapability = cardholderAuthenticationCapability;
			this.CardCaptureCapability = cardCaptureCapability;
			this.OperatingEnvironment = operatingEnvironment;
			this.CardholderPresent = cardholderPresent;
			this.CardPresent = cardPresent;
			this.CardDataInputMode = cardDataInputMode;
			this.CardholderAuthenticationMethod = cardholderAuthenticationMethod;
			this.CardholderAuthenticationEntity = cardholderAuthenticationEntity;
			this.CardDataOutputCapability = cardDataOutputCapability;
			this.TerminalOutputCapability = terminalOutputCapability;
			this.PINCaptureCapability = pINCaptureCapability;
			this.TerminalOperator = terminalOperator;
			this.TerminalType = terminalType;
		}

		public POSDataCode(string cardDataInputCapability, string cardholderAuthenticationCapability, string cardCaptureCapability, string operatingEnvironment, string cardholderPresent, string cardPresent, string cardDataInputMode, string cardholderAuthenticationMethod, string cardholderAuthenticationEntity, string cardDataOutputCapability, string terminalOutputCapability, string pINCaptureCapability, string terminalOperator, string terminalType)
		{
			this.InitStrings(cardDataInputCapability, cardholderAuthenticationCapability, cardCaptureCapability, operatingEnvironment, cardholderPresent, cardPresent, cardDataInputMode, cardholderAuthenticationMethod, cardholderAuthenticationEntity, cardDataOutputCapability, terminalOutputCapability, pINCaptureCapability, terminalOperator, terminalType);
		}

		public POSDataCode(string posDataCode)
		{
			this.InitStrings(posDataCode.Substring(0, 1), posDataCode.Substring(1, 1), posDataCode.Substring(2, 1), posDataCode.Substring(3, 1), posDataCode.Substring(4, 1), posDataCode.Substring(5, 1), posDataCode.Substring(6, 1), posDataCode.Substring(7, 1), posDataCode.Substring(8, 1), posDataCode.Substring(9, 1), posDataCode.Substring(10, 1), posDataCode.Substring(11, 1), posDataCode.Substring(12, 1), posDataCode.Substring(13, 2));
		}

		public override string ToString()
		{
			return string.Concat(new string[]
			{
				EFTProperties<CardDataInputCapabilityEnum>.Value(this.CardDataInputCapability).Value,
				EFTProperties<CardholderAuthenticationCapabilityEnum>.Value(this.CardholderAuthenticationCapability).Value,
				EFTProperties<CardCaptureCapabilityEnum>.Value(this.CardCaptureCapability).Value,
				EFTProperties<OperatingEnvironmentEnum>.Value(this.OperatingEnvironment).Value,
				EFTProperties<CardholderPresentEnum>.Value(this.CardholderPresent).Value,
				EFTProperties<CardPresentEnum>.Value(this.CardPresent).Value,
				EFTProperties<CardDataInputModeEnum>.Value(this.CardDataInputMode).Value,
				EFTProperties<CardholderAuthenticationMethodEnum>.Value(this.CardholderAuthenticationMethod).Value,
				EFTProperties<CardholderAuthenticationEntityEnum>.Value(this.CardholderAuthenticationEntity).Value,
				EFTProperties<CardDataOutputCapabilityEnum>.Value(this.CardDataOutputCapability).Value,
				EFTProperties<TerminalOutputCapabilityEnum>.Value(this.TerminalOutputCapability).Value,
				EFTProperties<PINCaptureCapabilityEnum>.Value(this.PINCaptureCapability).Value,
				EFTProperties<TerminalOperatorEnum>.Value(this.TerminalOperator).Value,
				EFTProperties<TerminalTypeEnum>.Value(this.TerminalType).Value
			});
		}

		public static POSDataCode FromString(string posDataCode)
		{
			return new POSDataCode(posDataCode);
		}

		private void InitStrings(string cardDataInputCapability, string cardholderAuthenticationCapability, string cardCaptureCapability, string operatingEnvironment, string cardholderPresent, string cardPresent, string cardDataInputMode, string cardholderAuthenticationMethod, string cardholderAuthenticationEntity, string cardDataOutputCapability, string terminalOutputCapability, string pINCaptureCapability, string terminalOperator, string terminalType)
		{
			this.CardDataInputCapability = EFTProperties<CardDataInputCapabilityEnum>.Enum(cardDataInputCapability);
			this.CardholderAuthenticationCapability = EFTProperties<CardholderAuthenticationCapabilityEnum>.Enum(cardholderAuthenticationCapability);
			this.CardCaptureCapability = EFTProperties<CardCaptureCapabilityEnum>.Enum(cardCaptureCapability);
			this.OperatingEnvironment = EFTProperties<OperatingEnvironmentEnum>.Enum(operatingEnvironment);
			this.CardholderPresent = EFTProperties<CardholderPresentEnum>.Enum(cardholderPresent);
			this.CardPresent = EFTProperties<CardPresentEnum>.Enum(cardPresent);
			this.CardDataInputMode = EFTProperties<CardDataInputModeEnum>.Enum(cardDataInputMode);
			this.CardholderAuthenticationMethod = EFTProperties<CardholderAuthenticationMethodEnum>.Enum(cardholderAuthenticationMethod);
			this.CardholderAuthenticationEntity = EFTProperties<CardholderAuthenticationEntityEnum>.Enum(cardholderAuthenticationEntity);
			this.CardDataOutputCapability = EFTProperties<CardDataOutputCapabilityEnum>.Enum(cardDataOutputCapability);
			this.TerminalOutputCapability = EFTProperties<TerminalOutputCapabilityEnum>.Enum(terminalOutputCapability);
			this.PINCaptureCapability = EFTProperties<PINCaptureCapabilityEnum>.Enum(pINCaptureCapability);
			this.TerminalOperator = EFTProperties<TerminalOperatorEnum>.Enum(terminalOperator);
			this.TerminalType = EFTProperties<TerminalTypeEnum>.Enum(terminalType);
		}
	}
}
