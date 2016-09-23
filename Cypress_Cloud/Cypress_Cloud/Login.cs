using System;
using SQLite.Net.Attributes;

namespace Cypress_Cloud
{
	public class Login
	{
		[PrimaryKey, AutoIncrement] 
		public int UserId { get; set;}
		public string UserName { get; set;}
		public string Password { get; set;}

		public override string ToString()
		{
			return string.Format("[Login: UserId={0}, UserName={1}, Password={2}]", UserId, UserName, Password);
		}
	}
}
