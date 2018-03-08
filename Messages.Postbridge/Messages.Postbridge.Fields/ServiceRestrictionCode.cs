using Messages.Core.Field;
using Messages.Postbridge.Enums;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Fields
{
	public class ServiceRestrictionCode : Empty
	{
		public Messages.Postbridge.Helpers.ServiceRestrictionCode SVC
		{
			get
			{
				return Messages.Postbridge.Helpers.ServiceRestrictionCode.FromString(base.Content);
			}
			set
			{
				base.Content = value.ToString();
			}
		}

		public AreaOfUsageEnum AreaOfUsage
		{
			get
			{
				return this.SVC.AreaOfUsage;
			}
			set
			{
				Messages.Postbridge.Helpers.ServiceRestrictionCode sVC = this.SVC;
				sVC.AreaOfUsage = value;
				this.SVC = sVC;
			}
		}

		public AuthorizationProcessingRequirementsEnum AuthorizationProcessingRequirements
		{
			get
			{
				return this.SVC.AuthorizationProcessingRequirements;
			}
			set
			{
				Messages.Postbridge.Helpers.ServiceRestrictionCode sVC = this.SVC;
				sVC.AuthorizationProcessingRequirements = value;
				this.SVC = sVC;
			}
		}

		public ServicesAndPINRequirementsEnum ServicesAndPINRequirements
		{
			get
			{
				return this.SVC.ServicesAndPINRequirements;
			}
			set
			{
				Messages.Postbridge.Helpers.ServiceRestrictionCode sVC = this.SVC;
				sVC.ServicesAndPINRequirements = value;
				this.SVC = sVC;
			}
		}
	}
}
