using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DoAnGiuaKy.DAO
{
    public class RouteDAO
    {
        public static List<RouteDTO> SelectAll()
        {
            List<RouteDTO> routelist = new List<RouteDTO>();
            Connection conn = new Connection();

            string queryStr = "select * from route";
            DataTable result = conn.Execute(queryStr);

            for(int i = 0; i < result.Rows.Count; i++)
            {
                DataRow dataRow = result.Rows[i];

                string RouteID = dataRow.ItemArray[0].ToString();
                string departureLocation = dataRow.ItemArray[1].ToString();
                string arrivalLocation = dataRow.ItemArray[2].ToString();

                RouteDTO routeDTO = new RouteDTO(RouteID, departureLocation, arrivalLocation);
                routelist.Add(routeDTO);
            }
            return routelist;
        }

        public static void Insert(RouteDTO target)
        {
            Connection conn = new Connection();
            string insertStr = $"insert into customer value ('{target.RouteID}', '{target.departureLocation}', '{target.arrivalLocation}',";
            conn.ExecuteNonQuery(insertStr);
        }

        public static void Update(RouteDTO target)
        {
            Connection conn = new Connection();

            string UpdateStr = "update route set ";
            UpdateStr += $"RouteID = '{target.RouteID}',";
            UpdateStr += $"departureLocation = '{target.departureLocation}',";
            UpdateStr += $"arrivalLocation = '{target.arrivalLocation}',";
            UpdateStr += $"where RouteID = '{target.RouteID}',";

            conn.ExecuteNonQuery(UpdateStr);
        }

        public static void Delete(string id)
        {
            Connection conn = new Connection();
            string deleteStr = $"delete from Route where RouteID = '{id}'";
            conn.ExecuteNonQuery(deleteStr);
        }
    }
}
