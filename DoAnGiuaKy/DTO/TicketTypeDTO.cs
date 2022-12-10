using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnGiuaKy.DTO
{
    internal class TicketTypeDTO
    {
        public string typeID { get; set; }
        public string typeName { get; set; }
        public int waittingRoom { get; set; }
        public float typePrice { get; set; }

        public TicketTypeDTO()
        {

        }
        public TicketTypeDTO(string typeID, string typeName, int waittingRoom, float typePrice)
        {
            this.typeID = typeID;
            this.typeName = typeName;
            this.waittingRoom = waittingRoom;
            this.typePrice = typePrice;
        }
    }
}
