using System;
using SQLite;

namespace Cypress_Cloud
{
	public interface ISQLite
	{
		SQLite.Net.SQLiteConnection GetConnection();
	}
}

