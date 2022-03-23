using Dapper;
using MediaBazaarModel.Logic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

//using System.Windows.Forms;

namespace MediaBazaarModel.sql
{
	public class SqlConPositions : ISqlConnectable<Position, PositionsManager>
	{
		public void AddItem(Position item)
		{
			throw new NotImplementedException();
		}

		public void RemoveItem(Position item)
		{
			throw new NotImplementedException();
		}

		public void UpdateItem(Position item)
		{
			throw new NotImplementedException();
		}

		public PositionsManager GetAllFromDatabase()
		{
			using (IDbConnection connection = new SqlConnection(Helper.ConVal("MediaBazaarDB")))
			{
				var positionList = connection.Query<Position>($"GetAllPositions").ToList();
				var positionsManager = new PositionsManager();
				positionsManager.AddRange(positionList);

				return positionsManager;
			}
		}

		public Position GetIdFromDatabase(int id)
		{
			throw new NotImplementedException();
		}
	}
}