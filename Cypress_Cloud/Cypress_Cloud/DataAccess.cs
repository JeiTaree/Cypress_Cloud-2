using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using System.IO;
using SQLite.Net;

namespace Cypress_Cloud
{
	public class DataAccess : IDisposable
	{
		private SQLiteConnection connection;

		public DataAccess()
		{
			var config = DependencyService.Get<IConfig>();
			connection = new SQLiteConnection(config.platform, Path.Combine(config.DBdirec, "Login.db3"));
			connection.CreateTable<Login>();
		}

		public void InsertLogin(Login login)
		{
			connection.Insert(login);
		}

		public void UpdateLogin(Login login)
		{
			connection.Update(login);
		}

		public void DeleteLogin(Login login)
		{
			connection.Delete(login);
		}

		public Login GetLogin(int UserId)
		{
			return connection.Table<Login>().FirstOrDefault(c => c.UserId == UserId);
		}

		public List<Login> GetLogins(int UserId)
		{
			return connection.Table<Login>().OrderBy(c => c.UserName).ToList();
		}

		public void Dispose()
		{
			connection.Dispose();
			
		}

	}
}
