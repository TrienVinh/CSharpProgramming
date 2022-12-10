using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;

namespace DoAnGiuaKy.BUS
{
    internal class TicketBus
    {
        public List<TicketDTO> list { get; private set; } = TicketDao.getAll();

        public TicketDTO get(string id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ticketID.ToLower().Equals(id.ToLower()))
                    return list[i];
            }
            return null;
        }

        public void add(TicketDTO ticket)
        {
            list.Add(ticket);
            TicketDao.insert(ticket);
        }
        
        public void set(TicketDTO ticket)
        {
            for(int i = 0; i < list.Count; i++)
                if (list[i].ticketID.ToLower().Equals(ticket.ticketID.ToLower()))
                {
                    list.RemoveAt(i);
                    list.Add(ticket);
                    TicketDao.update(ticket);
                    return;
                }
        }

        public void delete(string id)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].ticketID.ToLower().Equals(id.ToLower()))
                {
                    list.RemoveAt(i);
                    TicketDao.delete(id);
                    return;
                }
            }
        }

        public void reload()
        {
            list.Clear();
            list = TicketDao.getAll();
        }

        public List<TicketDTO> Search(String ticketid, string customerid, string flightid, string invoiceid, string typeid)
        {
            List<TicketDTO> result = new List<TicketDTO>();
            
            ticketid = ticketid.ToLower().Trim();
            customerid = customerid.ToLower().Trim();
            flightid = flightid.ToLower().Trim();
            invoiceid = invoiceid.ToLower().Trim();
            typeid = typeid.ToLower().Trim();
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].customerID.ToLower().Contains(customerid) && list[i].ticketID.ToLower().Contains(ticketid) && list[i].flightID.ToLower().Contains(flightid) 
                    && list[i].invoiceID.ToLower().Contains(invoiceid) && list[i].typeID.ToLower().Contains(typeid) )
                    result.Add(list[i]);
            }

            return result;
        }

    }
}
