using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKy.DTO
{
    internal class InvoiceDetailDTO
    {
        public string invoiceID { get; set; }
        public string typeID { get; set; }
        public int amount { get; set; }
        public float total { get; set; }

        public InvoiceDetailDTO()
        {

        }
        public InvoiceDetailDTO(string invoiceID, string typeID, int amount, float total)
        {
            this.invoiceID = invoiceID;
            this.typeID = typeID;
            this.amount = amount;
            this.total = total;
        }
    }
}
