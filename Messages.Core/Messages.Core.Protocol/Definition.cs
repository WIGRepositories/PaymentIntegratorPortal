using Messages.Core.Field;
using Messages.Core.Field.Formatters;
using Messages.Core.Field.Parsers;
using Messages.Core.Field.Validators;
using Messages.Licensing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;

namespace Messages.Core.Protocol
{
	[Serializable]
	public class Definition : IDefinition, ICloneable
	{
		private const string MESSAGE_TBL = "Message";

		private const string ELEMENTS_TBL = "Elements";

		private const string GROUPS_TBL = "Groups";

		private const string GROUPS_ELEMENTS_TBL = "GroupsElements";

		private const string NAME_TBL = "Protocol";

		private const string NAME_FIELD = "Name";

		private const string GROUP_FIELD = "Group";

		private const string ELEMENT_FIELD = "Element";

		private const string SIZE_FIELD = "Size";

		private const string NUMBER_FIELD = "Number";

		private const string FIELDLEN_FIELD = "FieldLength";

		private const string FIELDFORMAT_FIELD = "FieldFormat";

		private const string FORMATTER_FIELD = "Formatter";

		private const string VALIDATOR_FIELD = "Validator";

		private const string PARSER_FIELD = "Parser";

		private const string BITMAP_FIELD = "Bitmap";

		private const string BITMAPHEX_FIELD = "HexBitmap";

		private const string BITMAPSTART_FIELD = "BitmapStartRange";

		private const string BITMAPEND_FIELD = "BitmapEndRange";

		private const string BITMAPFIRST_FIELD = "BitmapFirst";

		private const string PROTOCOL_FIELD = "Name";

		private static License lic;

		public string Name
		{
			get;
			set;
		}

		public SortedList<int, IField> Fields
		{
			get;
			private set;
		}

		public Definition()
		{
			this.Init("No name", new SortedList<int, IField>());
		}

		public IDefinition AddField(IField field)
		{
			this.VerifyLicense(true);
			this.Fields.Add(field.Number, field);
			return this;
		}

		public void ReadXML(string fileName)
		{
			this.VerifyLicense(true);
			this.Fields.Clear();
			using (DataSet dataSet = new DataSet())
			{
				dataSet.ReadXml(fileName);
				SortedList<string, IField> sortedList = new SortedList<string, IField>();
				SortedList<string, IField> sortedList2 = new SortedList<string, IField>();
				SortedList<string, SortedList<string, string>> sortedList3 = new SortedList<string, SortedList<string, string>>();
				SortedList<string, int> bitmapLows = new SortedList<string, int>();
				SortedList<string, int> bitmapHighs = new SortedList<string, int>();
				foreach (DataRow dr in dataSet.Tables["Elements"].Rows)
				{
					IField field = this.ReadFieldFromTable(dr, "Element", bitmapLows, bitmapHighs);
					sortedList.Add(field.Name, field);
				}
				if (dataSet.Tables.Contains("Groups"))
				{
					foreach (DataRow dr2 in dataSet.Tables["Groups"].Rows)
					{
						IField field2 = this.ReadFieldFromTable(dr2, "Group", bitmapLows, bitmapHighs);
						sortedList2.Add(field2.Name, field2);
					}
					foreach (DataRow dataRow in dataSet.Tables["GroupsElements"].Rows)
					{
						string key = (string)dataRow["Group"];
						if (!sortedList3.ContainsKey(key))
						{
							sortedList3.Add(key, new SortedList<string, string>());
						}
						sortedList3[key].Add((string)dataRow["Element"], string.Empty);
					}
				}
				foreach (DataRow dataRow2 in dataSet.Tables["Message"].Rows)
				{
					string key2 = (string)dataRow2["Name"];
					if (sortedList.ContainsKey(key2))
					{
						this.AddField(sortedList[key2]);
					}
					else
					{
						this.PopulateFieldWithSubfields(sortedList2[key2], sortedList, sortedList2, sortedList3);
						this.AddField(sortedList2[key2]);
					}
				}
				foreach (int current in this.Fields.Keys)
				{
					this.MapBitmapRanges(this.Fields[current], this.Fields, bitmapLows, bitmapHighs);
				}
				this.Init((string)dataSet.Tables["Protocol"].Rows[0].ItemArray[0], this.Fields);
			}
		}

		private void MapBitmapRanges(IField field, SortedList<int, IField> fieldList, SortedList<string, int> bitmapLows, SortedList<string, int> bitmapHighs)
		{
			if (field.GetType().Equals(typeof(Bitmap)) || field.GetType().Equals(typeof(BitmapHex)))
			{
				((Bitmap)field).AddMappedFieldRange(bitmapLows[field.Name], bitmapHighs[field.Name], fieldList);
			}
			foreach (int current in field.Subfields.Keys)
			{
				this.MapBitmapRanges(field.Subfields[current], field.Subfields, bitmapLows, bitmapHighs);
			}
		}

		private void PopulateFieldWithSubfields(IField field, SortedList<string, IField> elements, SortedList<string, IField> groups, SortedList<string, SortedList<string, string>> elementsGroups)
		{
			SortedList<string, string> sortedList = elementsGroups[field.Name];
			foreach (string current in sortedList.Keys)
			{
				if (elements.ContainsKey(current))
				{
					field.AddSubfield(elements[current]);
				}
				else
				{
					this.PopulateFieldWithSubfields(groups[current], elements, groups, elementsGroups);
					field.AddSubfield(groups[current]);
				}
			}
		}

		private IField ReadFieldFromTable(DataRow dr, string elementName, SortedList<string, int> bitmapLows, SortedList<string, int> bitmapHighs)
		{
			FieldLength length;
			Enum.TryParse<FieldLength>((string)dr["FieldLength"], out length);
			FieldFormat format;
			Enum.TryParse<FieldFormat>((string)dr["FieldFormat"], out format);
			Messages.Core.Field.Empty empty;
			if (elementName != "Group" && Convert.ToBoolean(dr["Bitmap"]))
			{
				if (Convert.ToBoolean(dr["HexBitmap"]))
				{
					empty = new BitmapHex(Convert.ToInt32(dr["BitmapFirst"]));
				}
				else
				{
					empty = new Bitmap(Convert.ToInt32(dr["BitmapFirst"]));
				}
				bitmapLows.Add((string)dr[elementName], Convert.ToInt32(dr["BitmapStartRange"]));
				bitmapHighs.Add((string)dr[elementName], Convert.ToInt32(dr["BitmapEndRange"]));
			}
			else
			{
				empty = new Messages.Core.Field.Empty();
			}
			empty.Configure((string)dr[elementName], Convert.ToInt32(dr["Size"]), Convert.ToInt32(dr["Number"]), length, format, FormatHelpers.GetFormatter((string)dr["Formatter"]), ValidatorHelpers.GetValidator((string)dr["Validator"]), ParserHelpers.GetParser((string)dr["Parser"]));
			return empty;
		}

		public void WriteXML(string fileName)
		{
			this.VerifyLicense(true);
			using (DataSet dataSet = new DataSet())
			{
				dataSet.Tables.Add(new DataTable("Message"));
				dataSet.Tables.Add(new DataTable("Elements"));
				dataSet.Tables.Add(new DataTable("Groups"));
				dataSet.Tables.Add(new DataTable("GroupsElements"));
				dataSet.Tables.Add(new DataTable("Protocol"));
				dataSet.Tables["Message"].Columns.Add(new DataColumn("Name", typeof(string)));
				dataSet.Tables["Groups"].Columns.Add(new DataColumn("Group", typeof(string)));
				dataSet.Tables["Groups"].Columns.Add(new DataColumn("Size", typeof(int)));
				dataSet.Tables["Groups"].Columns.Add(new DataColumn("Number", typeof(int)));
				dataSet.Tables["Groups"].Columns.Add(new DataColumn("FieldLength", typeof(string)));
				dataSet.Tables["Groups"].Columns.Add(new DataColumn("FieldFormat", typeof(string)));
				dataSet.Tables["Groups"].Columns.Add(new DataColumn("Formatter", typeof(string)));
				dataSet.Tables["Groups"].Columns.Add(new DataColumn("Validator", typeof(string)));
				dataSet.Tables["Groups"].Columns.Add(new DataColumn("Parser", typeof(string)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("Element", typeof(string)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("Size", typeof(int)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("Number", typeof(int)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("FieldLength", typeof(string)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("FieldFormat", typeof(string)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("Formatter", typeof(string)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("Validator", typeof(string)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("Parser", typeof(string)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("Bitmap", typeof(bool)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("HexBitmap", typeof(bool)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("BitmapStartRange", typeof(int)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("BitmapEndRange", typeof(int)));
				dataSet.Tables["Elements"].Columns.Add(new DataColumn("BitmapFirst", typeof(int)));
				dataSet.Tables["GroupsElements"].Columns.Add(new DataColumn("Group", typeof(string)));
				dataSet.Tables["GroupsElements"].Columns.Add(new DataColumn("Element", typeof(string)));
				dataSet.Tables["Protocol"].Columns.Add(new DataColumn("Name", typeof(string)));
				foreach (int current in this.Fields.Keys)
				{
					this.ParseField(this.Fields[current], dataSet, string.Empty);
				}
				dataSet.Tables["Protocol"].Rows.Add(new object[]
				{
					this.Name
				});
				dataSet.WriteXml(fileName);
			}
		}

		private void ParseField(IField field, DataSet ds, string groupName)
		{
			if (field.Subfields.Count > 0)
			{
				ds.Tables["Groups"].Rows.Add(new object[]
				{
					field.Name,
					field.Size,
					field.Number,
					field.Length.ToString(),
					field.Format.ToString(),
					field.Formatter.ToString(),
					field.Validator.ToString(),
					field.Parser.ToString()
				});
				using (IEnumerator<int> enumerator = field.Subfields.Keys.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						ds.Tables["GroupsElements"].Rows.Add(new object[]
						{
							field.Name,
							field.Subfields[current].Name
						});
						this.ParseField(field.Subfields[current], ds, field.Name);
					}
					goto IL_4A5;
				}
			}
			if (field.GetType().Equals(typeof(BitmapHex)))
			{
				int key = ((BitmapHex)field).MappedFields.Keys.Min();
				int key2 = ((BitmapHex)field).MappedFields.Keys.Max();
				ds.Tables["Elements"].Rows.Add(new object[]
				{
					field.Name,
					field.Size,
					field.Number,
					field.Length.ToString(),
					field.Format.ToString(),
					field.Formatter.ToString(),
					field.Validator.ToString(),
					field.Parser.ToString(),
					true,
					true,
					((BitmapHex)field).MappedFields[key].Number,
					((BitmapHex)field).MappedFields[key2].Number,
					((BitmapHex)field).GetStartField()
				});
			}
			else if (field.GetType().Equals(typeof(Bitmap)))
			{
				int key3 = ((Bitmap)field).MappedFields.Keys.Min();
				int key4 = ((Bitmap)field).MappedFields.Keys.Max();
				ds.Tables["Elements"].Rows.Add(new object[]
				{
					field.Name,
					field.Size,
					field.Number,
					field.Length.ToString(),
					field.Format.ToString(),
					field.Formatter.ToString(),
					field.Validator.ToString(),
					field.Parser.ToString(),
					true,
					false,
					((Bitmap)field).MappedFields[key3].Number,
					((Bitmap)field).MappedFields[key4].Number,
					((Bitmap)field).GetStartField()
				});
			}
			else
			{
				ds.Tables["Elements"].Rows.Add(new object[]
				{
					field.Name,
					field.Size,
					field.Number,
					field.Length.ToString(),
					field.Format.ToString(),
					field.Formatter.ToString(),
					field.Validator.ToString(),
					field.Parser.ToString(),
					false
				});
			}
			IL_4A5:
			if (string.IsNullOrEmpty(groupName))
			{
				ds.Tables["Message"].Rows.Add(new object[]
				{
					field.Name
				});
			}
		}

		public static void AddLicense(License license)
		{
			Definition.lic = license;
		}

		protected void Init(string name, SortedList<int, IField> fields)
		{
			this.VerifyLicense(false);
			this.Name = name;
			this.Fields = fields;
		}

		private void VerifyLicense(bool checkEnterprise)
		{
            return;
			if (Definition.lic == null)
			{
				throw new SecurityException("No license found. Please call the AddLicense() method of the message definition before using other features of this library.");
			}
			if (!Definition.lic.IsValid)
			{
				Definition.lic.RSAPublicKey = "<RSAKeyValue><Modulus>r4agZ0jNHVKatPZsS9ENdbfwCZiAY92dPq7AAoyQ9i1vLI9GcBz04d54NdiAkkpu2BTu5WRHMrS7njIgzImbBEJPt/Yb76h59wlQuV6vxKU6e9EmyGooF1XM0uVVfHymKwVm3C7bp/KMiMIxRxxNAKGVLqVAsKVuXKFz4Am5UrH7Ae1Y2RR6nScpdXSCvdy6InV4V5ZZJamdKddGRihTgYcEFY2QQpE3WEJYdGsS4hoOrBnmKOfQl5UGeBWd0kEl7wpnRMrjtGYviZdDe4YfnPH44WcLzwQcyjIVkLmktNX0vA5xDIYkTNV804ggbowZmqVHBhEDfT60WWiX6Hns4w==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
				Definition.lic.Validate();
				if (!Definition.lic.IsValid)
				{
					throw new SecurityException("Invalid license found. Please provide a valid license.");
				}
			}
			if (Definition.lic.Type == LicenseType.Runtime && Debugger.IsAttached)
			{
				throw new SecurityException("Invalid use of runtime license. Please use a design or enteprise license.");
			}
			if (checkEnterprise && (Definition.lic.Type == LicenseType.Runtime || Definition.lic.Type == LicenseType.Design))
			{
				StackTrace stackTrace = new StackTrace(true);
				if (stackTrace.GetFrame(3).GetMethod().Module.Assembly.FullName.ToLower().IndexOf("8fcccfd340545823") == -1)
				{
					throw new SecurityException("Invalid use of runtime or design license. Please use an enterprise license.");
				}
			}
		}

		public object Clone()
		{
			object result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize(memoryStream, this);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				object obj = binaryFormatter.Deserialize(memoryStream);
				result = obj;
			}
			return result;
		}

		public byte[] CloneToByteArray()
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize(memoryStream, this);
				result = memoryStream.ToArray();
			}
			return result;
		}

		public static object CloneFromByteArray(byte[] serialized)
		{
			object result;
			using (MemoryStream memoryStream = new MemoryStream(serialized))
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				object obj = binaryFormatter.Deserialize(memoryStream);
				result = obj;
			}
			return result;
		}
	}
}
