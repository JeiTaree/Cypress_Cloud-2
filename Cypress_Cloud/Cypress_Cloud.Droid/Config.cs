using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(Cypress_Cloud.Droid.Config))]

namespace Cypress_Cloud.Droid
{
	public class Config : IConfig
	{
		private string dbdirec;
		private ISQLitePlatform Platform;

		public string DBdirec
		{
			get
			{
				if (string.IsNullOrEmpty(dbdirec))
				{
					 dbdirec = System.Environment.GetFolderPath(
						Environment.SpecialFolder.Personal);
				}
				return dbdirec;
			}

		}

		public SQLite.Net.Interop.ISQLitePlatform platform
		{
			get
			{
				if (Platform == null)
				{
					Platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
				}
				return Platform;
			}
		}
	}
}
