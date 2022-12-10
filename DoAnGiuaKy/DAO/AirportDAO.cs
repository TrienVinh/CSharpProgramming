using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;

namespace DoAnGiuaKy.DAO
{
	public class AirportDAO

	{
		public static List<AirportDTO> SelectAll()
		{
			List<AirportDTO> airportlist = new List<AirportDTO>();
			Connection conn = new Connection();

			string queryStr = "select * from airport";
			DataTable result = conn.Execute(queryStr);

			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];
				string airportID = datarow.ItemArray[0].ToString();
				string airportName = datarow.ItemArray[1].ToString();
				string airportCity = datarow.ItemArray[2].ToString();

				AirportDTO airport = new AirportDTO(airportID, airportName, airportCity);
				airportlist.Add(airport);

			}

			return airportlist;

		}

		public static void Insert(AirportDTO target)
		{
			Connection conn = new Connection();
			string insertStr = $"insert into airport values ('{target.airportID}', N'{target.airportName}', N'{target.airportCity}')";
			
			conn.ExecuteNonQuery(insertStr);
		}

		public static void Update(AirportDTO target)
		{
			Connection conn = new Connection();
			string UpdateStr = "update airport set ";
			UpdateStr += $"airportID = '{target.airportID}', ";
			UpdateStr += $"airportName = N'{target.airportName}', ";
			UpdateStr += $"airportCity = N'{target.airportCity}' ";
			UpdateStr += $"where airportID = '{target.airportID}'";

			conn.ExecuteNonQuery(UpdateStr);
		}

		public static void Delete(string id)
		{
			Connection conn = new Connection();
			string deleteStr = $"delete from airport where airportID = '{id}'";
			conn.ExecuteNonQuery(deleteStr);
		}

	}
}
