using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnGiuaKy.DTO;
using DoAnGiuaKy.DAO;

namespace DoAnGiuaKy.BUS
{
    internal class invoiceDetailBus
    {
        public List<InvoiceDetailDTO> list { get; private set; } = invoiceDetailDao.getAll();

        public InvoiceDetailDTO get(string ivdetailid, string typeid)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].invoiceID.ToLower().Equals(ivdetailid.ToLower()))
                    if (list[i].typeID.ToLower().Equals(typeid.ToLower()))
                        return list[i];
            return null;
        }

        public void set(InvoiceDetailDTO target)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].invoiceID.ToLower().Equals(target.invoiceID.ToLower()))
                    if (list[i].typeID.ToLower().Equals(target.typeID.ToLower()))
                    {
                        list.Remove(list[i]);
                        list.Add(target);
                        invoiceDetailDao.update(target);
                        return;
                    }
            }
        }

        public void add(InvoiceDetailDTO target)
        {
            list.Add(target);
            invoiceDetailDao.insert(target);
        }

        public void delete(string ivdid,string typeid)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].invoiceID.ToLower().Equals(ivdid.ToLower()))
                    if (list[i].typeID.ToLower().Equals(typeid.ToLower()))
                    {
                        list.Remove(list[i]);
                        invoiceDetailDao.delete(ivdid,typeid);
                        return;
                    }
        }

        public void reload()
        {
            list.Clear();
            list = invoiceDetailDao.getAll();
        }

        public List<InvoiceDetailDTO> Search(string invoiceID,string typeID)
        {
            List<InvoiceDetailDTO> result = new List<InvoiceDetailDTO>();

            invoiceID = invoiceID.ToLower().Trim();
            typeID = typeID.ToLower().Trim();

            for(int i = 0; i < list.Count(); i++)
            {
                if (list[i].typeID.ToLower().Contains(typeID) && list[i].invoiceID.ToLower().Contains(invoiceID))
                    result.Add(list[i]);
            }
            return result;
        }
    }
}
