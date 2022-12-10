using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnGiuaKy.DTO;
using System.Data;

namespace DoAnGiuaKy.DAO
{
    internal class TicketTypeDao
    {
        public static List<TicketTypeDTO> getAll()
        {
            Connection conn = new Connection();
            List<TicketTypeDTO> tickettypeList = new List<TicketTypeDTO>();
            string strquery = "select * from tickettype";
            DataTable result = conn.Execute(strquery);

            for(int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];
                
                string typeID = datarow.ItemArray[0].ToString();
                string typeName = datarow.ItemArray[1].ToString();
                int waittingRoom = int.Parse(datarow.ItemArray[2].ToString());
                float typePrice = float.Parse(datarow.ItemArray[3].ToString());

                tickettypeList.Add(new TicketTypeDTO(typeID, typeName, waittingRoom, typePrice));
            }

            return tickettypeList;
        }

        public static void insert(TicketTypeDTO tt)
        {
            Connection conn = new Connection();
            string insertsrt = $"insert into tickettype values ('{tt.typeID}', '{tt.typeName}', '{tt.waittingRoom}', '{tt.typePrice}')";
            conn.ExecuteNonQuery(insertsrt);
        }

        public static void update(TicketTypeDTO tt)
        {
            Connection conn = new Connection();
            string upstr = $"update tickettype set typeID = '{tt.typeID}', typeName = '{tt.typeName}', waittingRoom = '{tt.waittingRoom}', typePrice = '{tt.typePrice}' where typeID = '{tt.typeID}'";
            conn.ExecuteNonQuery(upstr);
        }

        public static void delete(string id)
        {
            Connection conn = new Connection();
            string delstr = $"delete from tickettype where typeID = '{id}'";
            conn.ExecuteNonQuery(delstr);
        }
    }
}
