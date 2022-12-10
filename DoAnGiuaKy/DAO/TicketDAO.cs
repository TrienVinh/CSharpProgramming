using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnGiuaKy.DTO;

namespace DoAnGiuaKy.DAO
{
    internal class TicketDao
    {
        public static List<TicketDTO> getAll()
        {
            Connection conn = new Connection();
            List<TicketDTO> ticketList = new List<TicketDTO>();
            String strquery = "select * from ticket";
            DataTable result = conn.Execute(strquery);

            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow dataRow = result.Rows[i];

                string ticketID = dataRow.ItemArray[0].ToString();
                string customerID = dataRow.ItemArray[1].ToString();
                string flightID = dataRow.ItemArray[2].ToString();
                string typeID = dataRow.ItemArray[3].ToString();
                string invoiceID = dataRow.ItemArray[4].ToString();

                ticketList.Add(new TicketDTO(ticketID, customerID, flightID, typeID, invoiceID));
            }

            return ticketList;
        }

        public static void insert(TicketDTO ticket)
        {
            Connection conn = new Connection();
            string insertTicket = $"insert into ticket values ('{ticket.ticketID}', '{ticket.customerID}', '{ticket.flightID}', '{ticket.typeID}', '{ticket.invoiceID}')";
            conn.ExecuteNonQuery(insertTicket);
        }

        public static void update(TicketDTO ticket)
        {
            Connection conn = new Connection();
            string upTicket = $"update ticket set ticketID = '{ticket.ticketID}', customerID = '{ticket.customerID}', flightID = '{ticket.flightID}', typeID ='{ticket.typeID}', invoiceID = '{ticket.invoiceID}' where ticketID = '{ticket.ticketID}'";
            conn.ExecuteNonQuery(upTicket);
        }

        public static void delete(string ticketid)
        {
            Connection conn = new Connection();
            string delTicket = $"delete from ticket where ticketID = '{ticketid}'";
            conn.ExecuteNonQuery(delTicket);
        }
    }
}
