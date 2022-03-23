using Dapper;
using MediaBazaarModel.Logic;
using Serilog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MediaBazaarModel.sql
{
	public class SqlConShifts : ISqlConnectable<Shift, ShiftManager>
	{
		public void AddItem(Shift item)
		{
			throw new NotImplementedException();
		}

		public void RemoveItem(Shift item)
		{
			throw new NotImplementedException();
		}

		public void UpdateItem(Shift item)
		{
			item.AllWorkersIntoIds();

			using (IDbConnection connection = new SqlConnection(Helper.ConVal("MediaBazaarDB")))
			{
				var sb = new StringBuilder();
				var p = new DynamicParameters();
				if (item.Id != -1)
				{
					sb.Append($"if exists(select id from WorkshiftDate where id = @ShiftId)\n");
					sb.Append("begin\n");
					sb.Append($"delete from WorkshiftUser where ShiftId = @ShiftId;");
					foreach (var i in item.WorkersIdList)
					{
						sb.Append($"insert into WorkshiftUser(ShiftId, UserId) values(@ShiftId, {i});\n");
					}
					sb.Append("end\n");

					p.Add("@ShiftId", item.Id);
				}
				else
				{
					sb.Append($"if exists(select id from WorkshiftDate where WorkDate = @Date and ShiftType = @ShiftType and DeptId = @DepartmentId)\n");
					sb.Append("begin\n");
					sb.Append($"delete from WorkshiftDate where WorkDate  = @Date and ShiftType = @ShiftType and DeptId = @DepartmentId;\n");
					sb.Append("end\n");
					sb.Append(
						$"insert into WorkshiftDate(WorkDate, ShiftType, DeptId) values(@Date, @ShiftType, @DepartmentId);\n");
					sb.Append("declare @i INT;\n");
					sb.Append(
						$"set @i = (select id from WorkshiftDate where WorkDate = @Date and ShiftType = @ShiftType and DeptId = @DepartmentId);\n");
					foreach (var i in item.WorkersIdList)
					{
						sb.Append($"insert into WorkshiftUser(ShiftId, UserId) values(@i, {i});\n");
					}

					p.Add("@Date", item.Date);
					p.Add("@ShiftType", item.ShiftType.ToString());
					p.Add("@DepartmentId", item.DepartmentId);
				}

				var sql = sb.ToString();
				connection.Open();
				using (var trans = connection.BeginTransaction())
				{
					try
					{
						connection.Execute(sql, p, trans);
						trans.Commit();
					}
					catch (Exception ex)
					{
						Log.Error(ex.Message);
						trans.Rollback();
					}
				}
			}
		}

		public ShiftManager GetAllFromDatabase()
		{
			using (IDbConnection connection = new SqlConnection(Helper.ConVal("MediaBazaarDB")))
			{
				var shiftList = connection.Query<ShiftDB>($"GetAllShifts").ToList();
				var shiftManager = new ShiftManager();

				foreach (var shift in shiftList)
				{
					var shiftToCompare = shiftManager.FindById(shift.Id);
					if (shiftToCompare != null)
					{
						shiftToCompare.AddId(shift.UserId);
					}
					else
					{
						shiftToCompare = new Shift(shift.Id, shift.WorkDate, shift.Type, shift.DeptId);
						shiftToCompare.AddId(shift.UserId);
						shiftManager.Add(shiftToCompare);
					}
				}

				return shiftManager;
			}
		}

		public Shift GetIdFromDatabase(int id)
		{
			throw new NotImplementedException();
		}
	}
}