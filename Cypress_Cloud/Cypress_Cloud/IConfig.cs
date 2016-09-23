using System;
using SQLite.Net.Interop;

namespace Cypress_Cloud
{
	public interface IConfig
	{
		string DBdirec { get;}
		ISQLitePlatform platform { get;}
	}
}
