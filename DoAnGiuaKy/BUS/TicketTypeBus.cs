using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;

namespace DoAnGiuaKy.BUS
{
    internal class TicketTypeBus
    {
        public List<TicketTypeDTO> list { get; private set; } = TicketTypeDao.getAll();

        public TicketTypeDTO get(string id)
        {
            for(int i = 0; i < list.Count; i++)
                if (list[i].typeID.ToLower().Equals(id.ToLower()))
                    return list[i];
            return null;
        }

        public void set(TicketTypeDTO ttype)
        {
            for(int i = 0; i < list.Count; i++)
                if (list[i].typeID.ToLower().Equals(ttype.typeID.ToLower()))
                {
                    list.Remove(list[i]);
                    list.Add(ttype);
                    TicketTypeDao.update(ttype);
                    return;
                }
        }

        public void add(TicketTypeDTO ttype)
        {
            list.Add(ttype);
            TicketTypeDao.insert(ttype);
        }

        public void delete(string id)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].typeID.ToLower().Equals(id.ToLower()))
                {
                    list.Remove(list[i]);
                    TicketTypeDao.delete(id);
                    return;
                }
        }

        public void reload()
        {
            list.Clear();
            list = TicketTypeDao.getAll();
        }

        public List<TicketTypeDTO> Search(string typeid,string typename)
        {
            List<TicketTypeDTO> result = new List<TicketTypeDTO>();

            typeid = typeid.ToLower().Trim();
            typename = typename.ToLower().Trim();

            for (int i = 0; i < list.Count; i++)
                if (list[i].typeID.ToLower().Contains(typeid) && list[i].typeName.ToLower().Contains(typename))
                    result.Add(list[i]);
            return result;
        }
    }
}
