using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(Cypress_Cloud.iOS.Config))]

namespace Cypress_Cloud.iOS
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
					var direc = System.Environment.GetFolderPath(
						Environment.SpecialFolder.Personal);
					dbdirec = System.IO.Path.Combine(direc, "...", "Library");
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
					Platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
				}
				return Platform;
			}
		}
	}
}
