using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKy.DTO
{
    internal class TicketDTO
    {
        public string ticketID { get; set; }
        public string customerID { get; set; }
        public string flightID { get; set; }
        public string typeID { get; set; }
        public string invoiceID { get; set; }

        public TicketDTO()
        {

        }
        public TicketDTO(string ticketID, string customerID, string flightID, string typeID, string invoiceID)
        {
            this.ticketID = ticketID;
            this.customerID = customerID;
            this.flightID = flightID;
            this.typeID = typeID;
            this.invoiceID = invoiceID;
        }
    }
}
