using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;

namespace DoAnGiuaKy.DAO
{
    public class FlightDAO
    {
        public static List<FlightDTO> SelectAll()
        {
            List<FlightDTO> Flightlist = new List<FlightDTO>();
            Connection conn = new Connection();

            string queryStr = "select * from flight";
            DataTable result = conn.Execute(queryStr);

            for(int i = 0; i < result.Rows.Count; i++)
            {
                DataRow dataRow = result.Rows[i];

                string FlightID = dataRow.ItemArray[0].ToString();
                string RouteID = dataRow.ItemArray[1].ToString();
                string airplaneID = dataRow.ItemArray[2].ToString();
                string FlightScheduleID = dataRow.ItemArray[3].ToString();
                string DepartureDay = dataRow.ItemArray[4].ToString();
                string ArrivalDay = dataRow.ItemArray[5].ToString();
                int totalSeats = int.Parse(dataRow.ItemArray[6].ToString());
                int ECOSeats = int.Parse(dataRow.ItemArray[7].ToString());
                int BUSSeats = int.Parse(dataRow.ItemArray[8].ToString());

                FlightDTO flightDTO = new FlightDTO(FlightID, RouteID, airplaneID, FlightScheduleID, DepartureDay, ArrivalDay, totalSeats, ECOSeats, BUSSeats);
                Flightlist.Add(flightDTO);
            }
            return Flightlist;
        }

        public static void Insert(FlightDTO target)
        {
            Connection conn = new Connection();
            string insertStr = $"insert into flight values ('{target.FlightID}', '{target.RouteID}', '{target.airplaneID}', '{target.flightScheduleID}','{target.departureDay}','{target.arrivalDay}' " +
                $"'{target.totalSeats}', '{target.ECOSeats}, '{target.BUSSeats}')";
            conn.ExecuteNonQuery(insertStr);
        }

        public static void Update(FlightDTO target)
        {
            Connection conn = new Connection();

            string UpdateStr = "update flight set ";
            UpdateStr += $"flightID = '{target.FlightID}', ";
            UpdateStr += $"routeID = '{target.RouteID}', ";
            UpdateStr += $"airplaneID = '{target.airplaneID}', ";
            UpdateStr += $"flightScheduleID = '{target.flightScheduleID}', ";
            UpdateStr += $"departureTime = '{target.departureDay}', ";
            UpdateStr += $"arrivalTime = '{target.arrivalDay}', ";
            UpdateStr += $"totalSeats = '{target.totalSeats}', ";
            UpdateStr += $"bookedECOSeats = '{target.ECOSeats}', ";
            UpdateStr += $"bookedBUSSeats = '{target.BUSSeats}' ";
            UpdateStr += $"where flightID = '{target.FlightID}',";

            conn.ExecuteNonQuery(UpdateStr);
        }

        public static void Delete(string id)
        {
            Connection conn = new Connection();
            string deleteStr = $"delete from flight where flightId = '{id}'";
            conn.ExecuteNonQuery(deleteStr);
        }
    }
}
