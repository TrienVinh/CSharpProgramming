using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnGiuaKy.DTO;
using System.Data;

namespace DoAnGiuaKy.DAO
{
    internal class invoiceDetailDao
    {
        public static List<InvoiceDetailDTO> getAll()
        {
            Connection conn = new Connection();
            List<InvoiceDetailDTO> ivDetailList = new List<InvoiceDetailDTO>();
            string strquery = "select * from invoicedetail";
            DataTable result = conn.Execute(strquery);

            for(int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];

                string invoiceID = datarow.ItemArray[0].ToString();
                string typeID = datarow.ItemArray[1].ToString();
                int amount = int.Parse(datarow.ItemArray[2].ToString());
                float total = float.Parse(datarow.ItemArray[3].ToString());

                ivDetailList.Add(new InvoiceDetailDTO(invoiceID, typeID, amount, total));
            }

            return ivDetailList;
        }

        public static void insert(InvoiceDetailDTO ivD)
        {
            Connection conn = new Connection();
            string insertsrt = $"insert into invoicedetail values ('{ivD.invoiceID}', '{ivD.typeID}', '{ivD.amount}', '{ivD.total}')";
            conn.ExecuteNonQuery(insertsrt);
        }

        public static void update(InvoiceDetailDTO ivD)
        {
            Connection conn = new Connection();
            string upstr = $"update invoicedetail set invoiceID = '{ivD.invoiceID}', typeID = '{ivD.typeID}', amount = '{ivD.amount}', total = '{ivD.total}' where invoiceID = '{ivD.invoiceID}' and typeID = '{ivD.typeID}'";
            conn.ExecuteNonQuery(upstr);
        }

        public static void delete(string invoiceid, string typeID)
        {
            Connection conn = new Connection();
            string delstr = $"delete from invoicedetail where invoiceID = '{invoiceid}' and typeID = '{typeID}'";
            conn.ExecuteNonQuery(delstr);
        }
    }
}
