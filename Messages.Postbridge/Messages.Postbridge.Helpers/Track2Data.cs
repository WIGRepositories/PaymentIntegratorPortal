using System;

namespace Messages.Postbridge.Helpers
{
	public class Track2Data
	{
		public string PAN
		{
			get;
			private set;
		}

		public string ExpiryDate
		{
			get;
			private set;
		}

		public string ServiceCode
		{
			get;
			private set;
		}

		public Track2Data(string track2)
		{
			char c = '=';
			if (track2.IndexOf(c) == -1)
			{
				c = 'D';
			}
			string[] array = track2.Split(new char[]
			{
				c
			});
			this.PAN = array[0];
			int num = 0;
			if (this.PAN.StartsWith("59"))
			{
				num = 3;
			}
			this.ExpiryDate = array[1].Substring(num, 4);
			this.ServiceCode = array[1].Substring(num + 4, 3);
		}

		public static Track2Data FromString(string track2)
		{
			return new Track2Data(track2);
		}
	}
}
