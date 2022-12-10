using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;

//namespace DoAnGiuaKy.DAO
namespace DoAnGiuaKy.DAO
{
	public class AirplaneDAO
	{
		public static List<AirplaneDTO> SelectAll()
		{
			List<AirplaneDTO> airplaneList = new List<AirplaneDTO>();
			Connection conn = new Connection();

			string queryStr = "select * from airplane";
			DataTable result = conn.Execute(queryStr);
			
			for(int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				string airplaneID = datarow.ItemArray[0].ToString();
				string airplaneName = datarow.ItemArray[1].ToString();
				string airplaneBrand = datarow.ItemArray[2].ToString(); 
				string airlineID = datarow.ItemArray[3].ToString();
				int eco = int.Parse(datarow.ItemArray[4].ToString());
				int bus = int.Parse(datarow.ItemArray[5].ToString());

				AirplaneDTO airplane = new AirplaneDTO(airplaneID, airplaneName, airplaneBrand, airlineID, eco, bus);
				airplaneList.Add(airplane);
			}

			return airplaneList;
		}

		public static void Insert(AirplaneDTO target)
		{
			Connection conn = new Connection();
			string insertStr = $"insert into airplane values ('{target.airplaneID}', '{target.airplaneName}', '{target.airplaneBrand}', " +
															$"'{target.airlineID}', '{target.ECOSeats}', '{target.BUSSeats}')";
			conn.ExecuteNonQuery(insertStr);
		}

		public static void Update(AirplaneDTO target)
		{
			Connection conn = new Connection();
			
			string updateStr = "update airplane set ";
			updateStr += $"airplaneID = '{target.airplaneID}', ";
			updateStr += $"airplaneName = '{target.airplaneName}', ";
			updateStr += $"airplaneBrand = '{target.airplaneBrand}', ";
			updateStr += $"airlineID = '{target.airlineID}', ";
			updateStr += $"ECOseats = '{target.ECOSeats}', ";
			updateStr += $"BUSseats = '{target.BUSSeats}' ";
			updateStr += $"where airplaneID = '{target.airplaneID}'";

			conn.ExecuteNonQuery(updateStr);
		}

		public static void Delete(string id)
		{
			Connection conn = new Connection();
			string deleteStr = $"delete from airplane where airplaneID = '{id}'";
			conn.ExecuteNonQuery(deleteStr);
		}
	}
}
