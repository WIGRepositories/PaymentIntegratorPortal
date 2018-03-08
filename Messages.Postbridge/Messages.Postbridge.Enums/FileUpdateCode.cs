using Messages.Core;
using Messages.Postbridge.Helpers;
using System;

namespace Messages.Postbridge.Enums
{
	[Enums]
	public class FileUpdateCode : EFTProperties<FileUpdateCodeEnum>
	{
		public static EFTConstant<string> Unassigned;

		public static EFTConstant<string> AddRecord;

		public static EFTConstant<string> ChangeRecord;

		public static EFTConstant<string> DeleteRecord;

		public static EFTConstant<string> BulkReplacement;

		public static EFTConstant<string> Inquiry;

		public static EFTConstant<string> DeleteRecordSystemPurge;

		public static EFTConstant<string> AddFile;

		public static EFTConstant<string> DeleteFile;

		public static EFTConstant<string> Unassigned2;

		static FileUpdateCode()
		{
			FileUpdateCode.Unassigned = new EFTConstant<string>("0");
			FileUpdateCode.AddRecord = new EFTConstant<string>("1");
			FileUpdateCode.ChangeRecord = new EFTConstant<string>("2");
			FileUpdateCode.DeleteRecord = new EFTConstant<string>("3");
			FileUpdateCode.BulkReplacement = new EFTConstant<string>("4");
			FileUpdateCode.Inquiry = new EFTConstant<string>("5");
			FileUpdateCode.DeleteRecordSystemPurge = new EFTConstant<string>("6");
			FileUpdateCode.AddFile = new EFTConstant<string>("7");
			FileUpdateCode.DeleteFile = new EFTConstant<string>("8");
			FileUpdateCode.Unassigned2 = new EFTConstant<string>("9");
			EFTProperties<FileUpdateCodeEnum>.Add(FileUpdateCodeEnum.AddFile, FileUpdateCode.AddFile);
			EFTProperties<FileUpdateCodeEnum>.Add(FileUpdateCodeEnum.AddRecord, FileUpdateCode.AddRecord);
			EFTProperties<FileUpdateCodeEnum>.Add(FileUpdateCodeEnum.BulkReplacement, FileUpdateCode.BulkReplacement);
			EFTProperties<FileUpdateCodeEnum>.Add(FileUpdateCodeEnum.ChangeRecord, FileUpdateCode.ChangeRecord);
			EFTProperties<FileUpdateCodeEnum>.Add(FileUpdateCodeEnum.DeleteFile, FileUpdateCode.DeleteFile);
			EFTProperties<FileUpdateCodeEnum>.Add(FileUpdateCodeEnum.DeleteRecord, FileUpdateCode.DeleteRecord);
			EFTProperties<FileUpdateCodeEnum>.Add(FileUpdateCodeEnum.DeleteRecordSystemPurge, FileUpdateCode.DeleteRecordSystemPurge);
			EFTProperties<FileUpdateCodeEnum>.Add(FileUpdateCodeEnum.Inquiry, FileUpdateCode.Inquiry);
			EFTProperties<FileUpdateCodeEnum>.Add(FileUpdateCodeEnum.Unassigned, FileUpdateCode.Unassigned);
			EFTProperties<FileUpdateCodeEnum>.Add(FileUpdateCodeEnum.Unassigned2, FileUpdateCode.Unassigned2);
		}
	}
}
