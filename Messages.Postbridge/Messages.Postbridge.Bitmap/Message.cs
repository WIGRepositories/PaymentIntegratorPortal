using Messages.Core.Field;
using Messages.Core.Message;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Fields;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Bitmap
{
	public class Message : Default
	{
		public Messages.Postbridge.Helpers.ProcessingCode ProcessingCode
		{
			get
			{
				return ((Messages.Postbridge.Fields.ProcessingCode)this.GetField(MessageFields.ProcessingCode)).Code;
			}
			set
			{
				this.Set(MessageFields.ProcessingCode);
				((Messages.Postbridge.Fields.ProcessingCode)this.GetField(MessageFields.ProcessingCode)).Code = value;
			}
		}

		public Messages.Postbridge.Fields.ProcessingCode ProcessingCodeField
		{
			get
			{
				return (Messages.Postbridge.Fields.ProcessingCode)this.GetField(MessageFields.ProcessingCode);
			}
		}

		public double TransactionAmount
		{
			get
			{
				return this.GetAmountField(MessageFields.TransactionAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.TransactionAmount, value);
			}
		}

		public double SettlementAmount
		{
			get
			{
				return this.GetAmountField(MessageFields.SettlementAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.SettlementAmount, value);
			}
		}

		public double TransactionFee
		{
			get
			{
				return this.GetAmountField(MessageFields.TransactionFee);
			}
			set
			{
				this.SetAmountField(MessageFields.TransactionFee, value);
			}
		}

		public double SettlementFee
		{
			get
			{
				return this.GetAmountField(MessageFields.SettlementFee);
			}
			set
			{
				this.SetAmountField(MessageFields.SettlementFee, value);
			}
		}

		public double TransactionProcessingFee
		{
			get
			{
				return this.GetAmountField(MessageFields.TransactionProcessingFee);
			}
			set
			{
				this.SetAmountField(MessageFields.TransactionProcessingFee, value);
			}
		}

		public double SettleProcessingFee
		{
			get
			{
				return this.GetAmountField(MessageFields.SettleProcessingFee);
			}
			set
			{
				this.SetAmountField(MessageFields.SettleProcessingFee, value);
			}
		}

		public double CreditsProcessingFee
		{
			get
			{
				return this.GetAmountField(MessageFields.CreditsProcessingFeeAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.CreditsProcessingFeeAmount, value);
			}
		}

		public double CreditsTransactionFee
		{
			get
			{
				return this.GetAmountField(MessageFields.CreditsTransactionFeeAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.CreditsTransactionFeeAmount, value);
			}
		}

		public double DebitsProcessingFee
		{
			get
			{
				return this.GetAmountField(MessageFields.DebitsProcessingFeeAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.DebitsProcessingFeeAmount, value);
			}
		}

		public double DebitsTransactionFee
		{
			get
			{
				return this.GetAmountField(MessageFields.DebitsTransactionFeeAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.DebitsTransactionFeeAmount, value);
			}
		}

		public double CreditAmount
		{
			get
			{
				return this.GetAmountField(MessageFields.CreditAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.CreditAmount, value);
			}
		}

		public double CreditReversalAmount
		{
			get
			{
				return this.GetAmountField(MessageFields.CreditReversalsAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.CreditReversalsAmount, value);
			}
		}

		public double DebitAmount
		{
			get
			{
				return this.GetAmountField(MessageFields.DebitAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.DebitAmount, value);
			}
		}

		public double DebitReversalAmount
		{
			get
			{
				return this.GetAmountField(MessageFields.DebitReversalAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.DebitReversalAmount, value);
			}
		}

		public double NetSettlementAmount
		{
			get
			{
				return this.GetAmountField(MessageFields.NetSettlementAmount);
			}
			set
			{
				this.SetAmountField(MessageFields.NetSettlementAmount, value);
			}
		}

		public DateTime TransmissionDateTime
		{
			get
			{
				return this.GetDateTimeFIeld(MessageFields.TransmissionDateAndTime);
			}
			set
			{
				this.SetDateTimeField(MessageFields.TransmissionDateAndTime, value);
			}
		}

		public DateTime LocalTransactionTime
		{
			get
			{
				return this.GetDateTimeFIeld(MessageFields.LocalTransactionTime);
			}
			set
			{
				this.SetDateTimeField(MessageFields.LocalTransactionTime, value);
			}
		}

		public DateTime LocalTransactionDate
		{
			get
			{
				return this.GetDateTimeFIeld(MessageFields.LocalTransactionDate);
			}
			set
			{
				this.SetDateTimeField(MessageFields.LocalTransactionDate, value);
			}
		}

		public DateTime ExpirationDate
		{
			get
			{
				return this.GetDateTimeFIeld(MessageFields.ExpirationDate);
			}
			set
			{
				this.SetDateTimeField(MessageFields.ExpirationDate, value);
			}
		}

		public DateTime SettlementDate
		{
			get
			{
				return this.GetDateTimeFIeld(MessageFields.SettlementDate);
			}
			set
			{
				this.SetDateTimeField(MessageFields.SettlementDate, value);
			}
		}

		public DateTime ConversionDate
		{
			get
			{
				return this.GetDateTimeFIeld(MessageFields.ConversionDate);
			}
			set
			{
				this.SetDateTimeField(MessageFields.ConversionDate, value);
			}
		}

		public Messages.Postbridge.Helpers.POSEntryMode POSEntryMode
		{
			get
			{
				return ((Messages.Postbridge.Fields.POSEntryMode)this.GetField(MessageFields.POSEntryMode)).Mode;
			}
			set
			{
				this.Set(MessageFields.POSEntryMode);
				((Messages.Postbridge.Fields.POSEntryMode)this.GetField(MessageFields.POSEntryMode)).Mode = value;
			}
		}

		public Messages.Postbridge.Fields.POSEntryMode POSEntryModeField
		{
			get
			{
				return (Messages.Postbridge.Fields.POSEntryMode)this.GetField(MessageFields.POSEntryMode);
			}
		}

		public POSConditionCodeEnum POSConditionCode
		{
			get
			{
				return ((Messages.Postbridge.Fields.POSConditionCode)this.GetField(MessageFields.POSConditionCode)).Code;
			}
			set
			{
				this.Set(MessageFields.POSConditionCode);
				((Messages.Postbridge.Fields.POSConditionCode)this.GetField(MessageFields.POSConditionCode)).Code = value;
			}
		}

		public ResponseCodeEnum ResponseCode
		{
			get
			{
				return ((Messages.Postbridge.Fields.ResponseCode)this.GetField(MessageFields.ResponseCode)).Code;
			}
			set
			{
				this.Set(MessageFields.ResponseCode);
				((Messages.Postbridge.Fields.ResponseCode)this.GetField(MessageFields.ResponseCode)).Code = value;
			}
		}

		public MessageTypeEnum MessageType
		{
			get
			{
				return ((Messages.Postbridge.Fields.MessageType)this.GetField(MessageFields.MTI)).Code;
			}
			set
			{
				this.Set(MessageFields.MTI);
				((Messages.Postbridge.Fields.MessageType)this.GetField(MessageFields.MTI)).Code = value;
			}
		}

		public Messages.Postbridge.Helpers.ServiceRestrictionCode ServiceRestrictionCode
		{
			get
			{
				return ((Messages.Postbridge.Fields.ServiceRestrictionCode)this.GetField(MessageFields.ServiceRestrictionCode)).SVC;
			}
			set
			{
				this.Set(MessageFields.ServiceRestrictionCode);
				((Messages.Postbridge.Fields.ServiceRestrictionCode)this.GetField(MessageFields.ServiceRestrictionCode)).SVC = value;
			}
		}

		public Messages.Postbridge.Fields.ServiceRestrictionCode ServiceRestrictionCodeField
		{
			get
			{
				return (Messages.Postbridge.Fields.ServiceRestrictionCode)this.GetField(MessageFields.ServiceRestrictionCode);
			}
		}

		public Messages.Postbridge.Helpers.CardAcceptorNameLocation CardAcceptorNameLocation
		{
			get
			{
				return ((Messages.Postbridge.Fields.CardAcceptorNameLocation)this.GetField(MessageFields.CardAcceptorNameLocation)).NameLocation;
			}
			set
			{
				this.Set(MessageFields.CardAcceptorNameLocation);
				((Messages.Postbridge.Fields.CardAcceptorNameLocation)this.GetField(MessageFields.CardAcceptorNameLocation)).NameLocation = value;
			}
		}

		public Messages.Postbridge.Fields.CardAcceptorNameLocation CardAcceptorNameLocationField
		{
			get
			{
				return (Messages.Postbridge.Fields.CardAcceptorNameLocation)this.GetField(MessageFields.CardAcceptorNameLocation);
			}
		}

		public Messages.Postbridge.Helpers.AdditionalAmounts AdditionalAmounts
		{
			get
			{
				return ((Messages.Postbridge.Fields.AdditionalAmounts)this.GetField(MessageFields.AdditionalAmounts)).Amounts;
			}
			set
			{
				this.Set(MessageFields.AdditionalAmounts);
				((Messages.Postbridge.Fields.AdditionalAmounts)this.GetField(MessageFields.AdditionalAmounts)).Amounts = value;
			}
		}

		public Messages.Postbridge.Fields.AdditionalAmounts AdditionalAmountsField
		{
			get
			{
				return (Messages.Postbridge.Fields.AdditionalAmounts)this.GetField(MessageFields.AdditionalAmounts);
			}
		}

		public MessageReasonCodeEnum MessageReasonCode
		{
			get
			{
				return ((Messages.Postbridge.Fields.MessageReasonCode)this.GetField(MessageFields.MessageReasonCode)).ReasonCode;
			}
			set
			{
				this.Set(MessageFields.MessageReasonCode);
				((Messages.Postbridge.Fields.MessageReasonCode)this.GetField(MessageFields.MessageReasonCode)).ReasonCode = value;
			}
		}

		public SettlementCodeEnum SettlementCode
		{
			get
			{
				return ((Messages.Postbridge.Fields.SettlementCode)this.GetField(MessageFields.SettlementCode)).Code;
			}
			set
			{
				this.Set(MessageFields.SettlementCode);
				((Messages.Postbridge.Fields.SettlementCode)this.GetField(MessageFields.SettlementCode)).Code = value;
			}
		}

		public NetworkManagementCodeEnum NetworkManagementCode
		{
			get
			{
				return ((Messages.Postbridge.Fields.NetworkManagementCode)this.GetField(MessageFields.NetworkManagementInformationCode)).Code;
			}
			set
			{
				this.Set(MessageFields.NetworkManagementInformationCode);
				((Messages.Postbridge.Fields.NetworkManagementCode)this.GetField(MessageFields.NetworkManagementInformationCode)).Code = value;
			}
		}

		public Messages.Postbridge.Helpers.OriginalDataElements OriginalDataElements
		{
			get
			{
				return ((Messages.Postbridge.Fields.OriginalDataElements)this.GetField(MessageFields.OriginalDataElements)).DataElements;
			}
			set
			{
				this.Set(MessageFields.OriginalDataElements);
				((Messages.Postbridge.Fields.OriginalDataElements)this.GetField(MessageFields.OriginalDataElements)).DataElements = value;
			}
		}

		public Messages.Postbridge.Fields.OriginalDataElements OriginalDataElementsField
		{
			get
			{
				return (Messages.Postbridge.Fields.OriginalDataElements)this.GetField(MessageFields.OriginalDataElements);
			}
		}

		public FileUpdateCodeEnum FileUpdateCode
		{
			get
			{
				return ((Messages.Postbridge.Fields.FileUpdateCode)this.GetField(MessageFields.FileUpdateCode)).Code;
			}
			set
			{
				this.Set(MessageFields.FileUpdateCode);
				((Messages.Postbridge.Fields.FileUpdateCode)this.GetField(MessageFields.FileUpdateCode)).Code = value;
			}
		}

		public Messages.Postbridge.Helpers.ReplacementAmounts ReplacementAmounts
		{
			get
			{
				return ((Messages.Postbridge.Fields.ReplacementAmounts)this.GetField(MessageFields.ReplacementAmounts)).Amounts;
			}
			set
			{
				this.Set(MessageFields.ReplacementAmounts);
				((Messages.Postbridge.Fields.ReplacementAmounts)this.GetField(MessageFields.ReplacementAmounts)).Amounts = value;
			}
		}

		public Messages.Postbridge.Fields.ReplacementAmounts ReplacementAmountsField
		{
			get
			{
				return (Messages.Postbridge.Fields.ReplacementAmounts)this.GetField(MessageFields.ReplacementAmounts);
			}
		}

		public Messages.Postbridge.Helpers.POSDataCode POSDataCode
		{
			get
			{
				return ((Messages.Postbridge.Fields.POSDataCode)this.GetField(MessageFields.POSDataCode)).DataCode;
			}
			set
			{
				this.Set(MessageFields.POSDataCode);
				((Messages.Postbridge.Fields.POSDataCode)this.GetField(MessageFields.POSDataCode)).DataCode = value;
			}
		}

		public Messages.Postbridge.Fields.POSDataCode POSDataCodeField
		{
			get
			{
				return (Messages.Postbridge.Fields.POSDataCode)this.GetField(MessageFields.POSDataCode);
			}
		}

		public Messages.Postbridge.Helpers.Track2Data Track2Data
		{
			get
			{
				return ((Messages.Postbridge.Fields.Track2Data)this.GetField(MessageFields.Track2Data)).T2Data;
			}
		}

		public Messages.Postbridge.Helpers.RoutingInformation RoutingInformation
		{
			get
			{
				return ((Messages.Postbridge.Fields.RoutingInformation)this.GetPrivateField(PrivateFields.RoutingInformation)).RoutingInfo;
			}
			set
			{
				this.SetPrivate(PrivateFields.RoutingInformation);
				((Messages.Postbridge.Fields.RoutingInformation)this.GetPrivateField(PrivateFields.RoutingInformation)).RoutingInfo = value;
			}
		}

		public Messages.Postbridge.Fields.RoutingInformation RoutingInformationField
		{
			get
			{
				return (Messages.Postbridge.Fields.RoutingInformation)this.GetPrivateField(PrivateFields.RoutingInformation);
			}
		}

		public Messages.Postbridge.Helpers.POSData POSData
		{
			get
			{
				return ((Messages.Postbridge.Fields.POSData)this.GetPrivateField(PrivateFields.POSData)).Data;
			}
			set
			{
				this.SetPrivate(PrivateFields.POSData);
				((Messages.Postbridge.Fields.POSData)this.GetPrivateField(PrivateFields.POSData)).Data = value;
			}
		}

		public Messages.Postbridge.Fields.POSData POSDataField
		{
			get
			{
				return (Messages.Postbridge.Fields.POSData)this.GetPrivateField(PrivateFields.POSData);
			}
		}

		public Messages.Postbridge.Helpers.AuthorizationProfile AuthorizationProfile
		{
			get
			{
				return ((Messages.Postbridge.Fields.AuthorizationProfile)this.GetPrivateField(PrivateFields.AuthorizationProfile)).AuthProfile;
			}
			set
			{
				this.SetPrivate(PrivateFields.AuthorizationProfile);
				((Messages.Postbridge.Fields.AuthorizationProfile)this.GetPrivateField(PrivateFields.AuthorizationProfile)).AuthProfile = value;
			}
		}

		public Messages.Postbridge.Fields.AuthorizationProfile AuthorizationProfileField
		{
			get
			{
				return (Messages.Postbridge.Fields.AuthorizationProfile)this.GetPrivateField(PrivateFields.AuthorizationProfile);
			}
		}

		public Messages.Postbridge.Helpers.POSGeographicData POSGeographicData
		{
			get
			{
				return ((Messages.Postbridge.Fields.POSGeographicData)this.GetPrivateField(PrivateFields.POSGeographicData)).GeographicData;
			}
			set
			{
				this.SetPrivate(PrivateFields.POSGeographicData);
				((Messages.Postbridge.Fields.POSGeographicData)this.GetPrivateField(PrivateFields.POSGeographicData)).GeographicData = value;
			}
		}

		public Messages.Postbridge.Fields.POSGeographicData POSGeographicDataField
		{
			get
			{
				return (Messages.Postbridge.Fields.POSGeographicData)this.GetPrivateField(PrivateFields.POSGeographicData);
			}
		}

		public StructuredDataItems StructuredData
		{
			get
			{
				return ((StructuredData)this.GetPrivateField(PrivateFields.StructuredData)).StructData;
			}
			set
			{
				this.SetPrivate(PrivateFields.StructuredData);
				((StructuredData)this.GetPrivateField(PrivateFields.StructuredData)).StructData = value;
			}
		}

		public CardVerificationResultEnum CardVerificationResult
		{
			get
			{
				return ((Messages.Postbridge.Fields.CardVerificationResult)this.GetPrivateField(PrivateFields.CardVerificationResult)).Result;
			}
			set
			{
				this.SetPrivate(PrivateFields.CardVerificationResult);
				((Messages.Postbridge.Fields.CardVerificationResult)this.GetPrivateField(PrivateFields.CardVerificationResult)).Result = value;
			}
		}

		public ExtendedTransactionTypeEnum ExtendedTransasctionType
		{
			get
			{
				return ((Messages.Postbridge.Fields.ExtendedTransactionType)this.GetPrivateField(PrivateFields.ExtendedTransactionType)).TranType;
			}
			set
			{
				this.SetPrivate(PrivateFields.ExtendedTransactionType);
				((Messages.Postbridge.Fields.ExtendedTransactionType)this.GetPrivateField(PrivateFields.ExtendedTransactionType)).TranType = value;
			}
		}

		public Messages.Postbridge.Helpers.AccountTypeQualifiers AccountTypeQualifiers
		{
			get
			{
				return ((Messages.Postbridge.Fields.AccountTypeQualifiers)this.GetPrivateField(PrivateFields.AccountTypeQualifiers)).Qualifiers;
			}
			set
			{
				this.SetPrivate(PrivateFields.AccountTypeQualifiers);
				((Messages.Postbridge.Fields.AccountTypeQualifiers)this.GetPrivateField(PrivateFields.AccountTypeQualifiers)).Qualifiers = value;
			}
		}

		public Messages.Postbridge.Fields.AccountTypeQualifiers AccountTypeQualifiersField
		{
			get
			{
				return (Messages.Postbridge.Fields.AccountTypeQualifiers)this.GetPrivateField(PrivateFields.AccountTypeQualifiers);
			}
		}

		public Messages.Postbridge.Helpers.TransactionReference TransactionReference
		{
			get
			{
				return ((Messages.Postbridge.Fields.TransactionReference)this.GetPrivateField(PrivateFields.TransactionReference)).TranReference;
			}
			set
			{
				this.SetPrivate(PrivateFields.TransactionReference);
				((Messages.Postbridge.Fields.TransactionReference)this.GetPrivateField(PrivateFields.TransactionReference)).TranReference = value;
			}
		}

		public Messages.Postbridge.Fields.TransactionReference TransactionReferenceField
		{
			get
			{
				return (Messages.Postbridge.Fields.TransactionReference)this.GetPrivateField(PrivateFields.TransactionReference);
			}
		}

		public LinkedAccounts LinkedAccounts
		{
			get
			{
				return new LinkedAccounts(this.GetField(MessageFields.AdditionalData).Content);
			}
			set
			{
				this.Set(MessageFields.AdditionalData).Content = value.ToString();
			}
		}

		public Message()
		{
			base.Definition = new Definition();
		}

		public IField GetField(MessageFields fieldNumber)
		{
			return base.Definition.Fields[Convert.ToInt32(fieldNumber)];
		}

		public IField Set(MessageFields fieldNumber)
		{
			return this.Set(Convert.ToInt32(fieldNumber));
		}

		public void Reset(MessageFields fieldNumber)
		{
			base.Reset(Convert.ToInt32(fieldNumber));
		}

		public IField GetPrivateField(PrivateFields fieldNumber)
		{
			return this.GetField(MessageFields.PrivateField).Subfields[Convert.ToInt32(fieldNumber)];
		}

		public IField GetPrivateField(int fieldNumber)
		{
			return this.GetField(MessageFields.PrivateField).Subfields[fieldNumber];
		}

		public IField GetICCField(ICCFields fieldNumber)
		{
			return this.GetPrivateField(PrivateFields.ICCData).Subfields[Convert.ToInt32(fieldNumber)];
		}

		public IField GetICCField(int fieldNumber)
		{
			return this.GetPrivateField(PrivateFields.ICCData).Subfields[fieldNumber];
		}

		public IField SetPrivate(PrivateFields fieldNumber)
		{
			return this.Set(MessageFields.PrivateField).Subfields[Convert.ToInt32(fieldNumber)];
		}

		public void ResetPrivate(PrivateFields fieldNumber)
		{
			this.GetField(MessageFields.PrivateField).Subfields[Convert.ToInt32(fieldNumber)].Content = string.Empty;
		}

		public bool IsFieldSet(MessageFields fieldNumber)
		{
			return this.GetField(fieldNumber).IsSet();
		}

		public bool IsPrivateFieldSet(PrivateFields fieldNumber)
		{
			return this.GetPrivateField(fieldNumber).IsSet();
		}

		public bool IsPrivateFieldSet(int fieldNumber)
		{
			return this.GetPrivateField(fieldNumber).IsSet();
		}

		public Message CopyField(Message message, MessageFields fieldNumber)
		{
			base.CopyField(message, Convert.ToInt32(fieldNumber));
			return this;
		}

		public Message CopyPrivateField(Message message, PrivateFields fieldNumber)
		{
			IField privateField = message.GetPrivateField(fieldNumber);
			IField privateField2 = this.GetPrivateField(fieldNumber);
			if (privateField.IsSet())
			{
				if (privateField2.Format != FieldFormat.Binary)
				{
					privateField2.Content = privateField.Content;
				}
				else
				{
					privateField2.Bytes = (byte[])Array.CreateInstance(typeof(byte), privateField.Bytes.Length);
					privateField.Bytes.CopyTo(privateField2.Bytes, 0);
				}
			}
			return this;
		}

		public Message CopyICCField(Message message, ICCFields fieldNumber)
		{
			IField iCCField = message.GetICCField(fieldNumber);
			IField iCCField2 = this.GetICCField(fieldNumber);
			if (iCCField.IsSet())
			{
				if (iCCField2.Format != FieldFormat.Binary)
				{
					iCCField2.Content = iCCField.Content;
				}
				else
				{
					iCCField2.Bytes = (byte[])Array.CreateInstance(typeof(byte), iCCField.Bytes.Length);
					iCCField.Bytes.CopyTo(iCCField2.Bytes, 0);
				}
			}
			return this;
		}

		public Messages.Postbridge.Helpers.OriginalDataElements ConstructOriginalDataElements()
		{
			return new Messages.Postbridge.Helpers.OriginalDataElements(this.GetField(MessageFields.MTI).Content, this.GetField(MessageFields.SystemsTraceAuditNumber).Content, this.GetField(MessageFields.TransmissionDateAndTime).Content, this.GetField(MessageFields.AcquiringInstututionID).Content, this.GetField(MessageFields.ForwardingInstututionID).Content);
		}

		private double GetAmountField(MessageFields fieldNumber)
		{
			return ((AmountField)this.GetField(fieldNumber)).Amount;
		}

		private void SetAmountField(MessageFields fieldNumber, double amount)
		{
			this.Set(fieldNumber);
			((AmountField)this.GetField(fieldNumber)).Amount = amount;
		}

		private DateTime GetDateTimeFIeld(MessageFields fieldNumber)
		{
			return ((DateTimeField)this.GetField(fieldNumber)).DateTime;
		}

		private void SetDateTimeField(MessageFields fieldNumber, DateTime DT)
		{
			this.Set(fieldNumber);
			((DateTimeField)this.GetField(fieldNumber)).DateTime = DT;
		}
	}
}
