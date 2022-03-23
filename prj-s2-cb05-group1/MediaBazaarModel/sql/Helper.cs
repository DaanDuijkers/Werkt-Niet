using System.Configuration;

namespace MediaBazaarModel.sql
{
	public static class Helper
	{
		public static string ConVal(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}
	}
}