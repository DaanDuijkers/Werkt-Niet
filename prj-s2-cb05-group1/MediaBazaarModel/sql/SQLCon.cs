using Serilog;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MediaBazaarModel.sql
{
	public static class SqlCon
	{
		/// <summary>
		/// credentials for the server, I know that they should be in separate file and be kept on gitignore file, but it's just for now
		/// </summary>
		private const string DataSource = "mssql.fhict.local";

		private const string UserId = "dbi472712_test";
		private const string Password = "Horseradish666";
		private const string InitialCatalog = "dbi472712_test";
		private static SqlConnectionStringBuilder _builder;
		private static SqlConnection _sqlConnection;

		/// <summary>
		/// constructor for the connection, it uses ConnectionStringbuilder for MySQL, because it looks nicer
		/// </summary>
		static SqlCon()
		{
			_builder = new SqlConnectionStringBuilder
			{
				DataSource = DataSource,
				UserID = UserId,
				Password = Password,
				InitialCatalog = InitialCatalog
			};
		}

		#region Common

		public static void OpenConnection()
		{
			_sqlConnection = new SqlConnection(_builder.ConnectionString);
			_sqlConnection.Open();
		}

		public static void CloseConnection()
		{
			_sqlConnection.Close();
		}

		public static SqlCommand Command(string query)
		{
			var cmd = new SqlCommand(query, _sqlConnection);
			return cmd;
		}

		public static DataTable SelectQuery(string sql)
		{
			using var connection = new SqlConnection(_builder.ConnectionString);
			//MessageBox.Show("Some text", "Some title", MessageBoxButtons.OK, MessageBoxIcon.Error);

			try
			{
				using var command = new SqlCommand(sql, connection);
				connection.Open();
				var da = new SqlDataAdapter(command);
				var dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (SqlException e)
			{
				//MessageBox.Show(e.ToString(), "Wrong db output", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Log.Error($"Wrong db output: {e}");
				return null;
			}
			catch (Exception e)
			{
				//MessageBox.Show(e.ToString(), "Wrong db output", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Log.Error($"Wrong db output: {e}");
				return null;
			}
			finally
			{
				connection.Close();
			}
		}

		#endregion Common
	}
}