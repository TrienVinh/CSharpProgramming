using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;

namespace DoAnGiuaKy.DAO
{
	public class InvoiceDAO
	{
		public static List<InvoiceDTO> SelectAll()
		{
			List<InvoiceDTO> invoiceList = new List<InvoiceDTO>();
			Connection conn = new Connection();

			string queryStr = "select * from invoice";
			DataTable result = conn.Execute(queryStr);

			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				string invoiceID = datarow.ItemArray[0].ToString();
				string staffID = datarow.ItemArray[1].ToString();
				string customerID = datarow.ItemArray[2].ToString();
				int invoiceTotal = int.Parse(datarow.ItemArray[3].ToString());
				string invoiceDateTime = datarow.ItemArray[4].ToString();

				InvoiceDTO invoice = new InvoiceDTO(invoiceID, staffID, customerID, invoiceTotal, invoiceDateTime);
				invoiceList.Add(invoice);
			}

			return invoiceList;
		}

		public static void Insert(InvoiceDTO target)
		{
			Connection conn = new Connection();
			string insertStr = $"insert into invoice values ('{target.invoiceID}', '{target.staffID}', '{target.customerID}', " +
															$"'{target.invoiceTotal}', '{target.invoiceDateTime}')";
			conn.ExecuteNonQuery(insertStr);
		}

		public static void Update(InvoiceDTO target)
		{
			Connection conn = new Connection();

			string updateStr = "update invoice set ";
			updateStr += $"invoiceID = '{target.invoiceID}', ";
			updateStr += $"staffID = '{target.staffID}', ";
			updateStr += $"customerID = '{target.customerID}', ";
			updateStr += $"invoiceTotal = '{target.invoiceTotal}', ";
			updateStr += $"invoiceDateTime = '{target.invoiceDateTime}' ";
			updateStr += $"where invoiceID = '{target.invoiceID}'";

			conn.ExecuteNonQuery(updateStr);
		}

		public static void Delete(string id)
		{
			Connection conn = new Connection();
			string deleteStr = $"delete from invoice where invoiceID = '{id}'";
			conn.ExecuteNonQuery(deleteStr);
		}
	}
}
