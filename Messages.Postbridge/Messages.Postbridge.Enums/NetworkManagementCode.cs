using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class NetworkManagementCode : EFTProperties<NetworkManagementCodeEnum>
	{
		public static EFTConstant<string> SignOnRequest;

		public static EFTConstant<string> SignOffRequest;

		public static EFTConstant<string> PINWorkingKeyChange;

		public static EFTConstant<string> MACWorkingKeyChange;

		public static EFTConstant<string> EchoTest;

		public static EFTConstant<string> Text;

		static NetworkManagementCode()
		{
			NetworkManagementCode.SignOnRequest = new EFTConstant<string>("001");
			NetworkManagementCode.SignOffRequest = new EFTConstant<string>("002");
			NetworkManagementCode.PINWorkingKeyChange = new EFTConstant<string>("101");
			NetworkManagementCode.MACWorkingKeyChange = new EFTConstant<string>("160");
			NetworkManagementCode.EchoTest = new EFTConstant<string>("301");
			NetworkManagementCode.Text = new EFTConstant<string>("999");
			EFTProperties<NetworkManagementCodeEnum>.Add(NetworkManagementCodeEnum.EchoTest, NetworkManagementCode.EchoTest);
			EFTProperties<NetworkManagementCodeEnum>.Add(NetworkManagementCodeEnum.MACWorkingKeyChange, NetworkManagementCode.MACWorkingKeyChange);
			EFTProperties<NetworkManagementCodeEnum>.Add(NetworkManagementCodeEnum.PINWorkingKeyChange, NetworkManagementCode.PINWorkingKeyChange);
			EFTProperties<NetworkManagementCodeEnum>.Add(NetworkManagementCodeEnum.SignOffRequest, NetworkManagementCode.SignOffRequest);
			EFTProperties<NetworkManagementCodeEnum>.Add(NetworkManagementCodeEnum.SignOnRequest, NetworkManagementCode.SignOnRequest);
			EFTProperties<NetworkManagementCodeEnum>.Add(NetworkManagementCodeEnum.Text, NetworkManagementCode.Text);
		}
	}
}
