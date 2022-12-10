using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;

namespace DoAnGiuaKy.DAO
{
	public class FlightScheduleDAO
	{
		public static List<FlightScheduleDTO> SelectAll()
		{
			List<FlightScheduleDTO> flightschedulelist = new List<FlightScheduleDTO>();
			Connection conn = new Connection();

			string queryStr = "select * from flightschedule";
			DataTable result = conn.Execute(queryStr);

			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];
				string flightScheduleID = datarow.ItemArray[0].ToString();
				string departureAirport = datarow.ItemArray[1].ToString();
				string arrivalAirport = datarow.ItemArray[2].ToString();
				string weekdays = datarow.ItemArray[3].ToString();
				string time = datarow.ItemArray[4].ToString();

				FlightScheduleDTO flightSchedule = new FlightScheduleDTO(flightScheduleID, departureAirport, arrivalAirport, weekdays, time);
				flightschedulelist.Add(flightSchedule);
			}    

			return flightschedulelist;
		}
		public static void Insert(FlightScheduleDTO target)
		{
			Connection conn = new Connection();
			string insertStr = $"insert into flightschedule values ('{target.flightScheduleID}', '{target.departureAirport}', '{target.arrivalAirport}', N'{target.weekdays}', '{target.time}')";

			conn.ExecuteNonQuery(insertStr);
		}

		public static void Update(FlightScheduleDTO target)
		{
			Connection conn = new Connection();

			string updateStr = "update flightschedule set ";
			updateStr += $"flightScheduleID = '{target.flightScheduleID}', ";
			updateStr += $"departureAirport = '{target.departureAirport}', ";
			updateStr += $"arrivalAirport = '{target.arrivalAirport}', ";
			updateStr += $"weekdays = N'{target.weekdays}', ";
			updateStr += $"time = '{target.time}' ";
			updateStr += $"where flightScheduleID = '{target.flightScheduleID}'";

			conn.ExecuteNonQuery(updateStr);
		}
		public static void Delete(string id)
		{
			Connection conn = new Connection();
			string deleteStr = $"delete from flightschedule where flightScheduleID = '{id}'";
			conn.ExecuteNonQuery(deleteStr);
		}
	}
}
