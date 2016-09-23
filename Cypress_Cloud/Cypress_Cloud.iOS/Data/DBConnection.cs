/*using System;
namespace Cypress_Cloud.iOS
{
	[assembly: Dependency(typeof(SQLite_iOS))]
	public class SQLite_iOS : ISQLite {
		public SQLite_iOS() { }
		public SQLite.Net.SQLiteConnection GetConnection()
		{
			var sqlitefilename = "TodoSQLite.db3";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine(documentsPath, "..", "Library");
			var path = Path.Combine(libraryPath, sqlitefilename);
			var conn = new SQLite.Net.SQLiteConnection(path);
			return conn;
		}
	}
}*/
