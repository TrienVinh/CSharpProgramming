//using DoAnGiuaKy.DAO;
//using DoAnGiuaKy.DTO;
using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;

//namespace DoAnGiuaKy.BUS
namespace DoAnGiuaKy.BUS
{
	public class InvoiceBUS
	{
		// Object's DTOs list.
		public List<InvoiceDTO> invoiceList { get; private set; } = InvoiceDAO.SelectAll();

		public void ReloadList()
		{
			invoiceList.Clear();
			invoiceList = InvoiceDAO.SelectAll();
		}

		public InvoiceDTO Get(string id)
		{
			for (int i = 0; i < invoiceList.Count; i++)
				if (invoiceList[i].invoiceID.ToLower().Equals(id.ToLower()))
					return invoiceList[i];

			return null;
		}

		public DataTable GetStaff()
		{
			DataTable dt = new Connection().Execute("select staffID from staff");
			return dt;
		}

		public DataTable GetCustomer()
		{
			DataTable dt = new Connection().Execute("select customerID from customer");
			return dt;
		}

		public void Insert(InvoiceDTO target)
		{
			invoiceList.Add(target);
			InvoiceDAO.Insert(target);
		}

		public void Update(InvoiceDTO target)
		{
			for (int i = 0; i < invoiceList.Count; i++)
				if (invoiceList[i].invoiceID.ToLower().Equals(target.invoiceID.ToLower()))
				{
					// Update the list.
					invoiceList.Remove(invoiceList[i]);
					invoiceList.Add(target);

					// Update the database.
					InvoiceDAO.Update(target);
					return;
				}
		}

		public void Delete(string id)
		{
			for (int i = 0; i < invoiceList.Count; i++)
				if (invoiceList[i].invoiceID.ToLower().Equals(id.ToLower()))
				{
					invoiceList.Remove(invoiceList[i]);
					InvoiceDAO.Delete(id);
					return;
				}
		}

		/// <summary>
		/// Search for a record by the selected criteria.
		/// </summary>
		/// <param name="tieuChiIndex"></param>
		/// <param name="searchTerm"></param>
		/// <returns></returns>
		public List<InvoiceDTO> Search(int tieuChiIndex, string searchTerm)
		{
			List<InvoiceDTO> result = new List<InvoiceDTO>();

			searchTerm = searchTerm.ToLower().Trim();

			switch (tieuChiIndex)
			{
				// Invoice ID.
				case 0:
					for (int i = 0; i < invoiceList.Count; i++)
						if (invoiceList[i].invoiceID.ToLower().Contains(searchTerm))
							result.Add(invoiceList[i]);
					break;
				
				// Staff ID.
				case 1:
					for (int i = 0; i < invoiceList.Count; i++)
						if (invoiceList[i].staffID.ToLower().Contains(searchTerm))
							result.Add(invoiceList[i]);
					break;

				// Customer ID.
				case 2:
					for (int i = 0; i < invoiceList.Count; i++)
						if (invoiceList[i].customerID.ToLower().Contains(searchTerm))
							result.Add(invoiceList[i]);
					break;
				
				// Invoice Total.
				case 3:
					for (int i = 0; i < invoiceList.Count; i++)
						if (invoiceList[i].invoiceTotal.ToString().Contains(searchTerm))
							result.Add(invoiceList[i]);
					break;
				
				// Invoice Datetime.
				case 4:
					for (int i = 0; i < invoiceList.Count; i++)
						if (invoiceList[i].invoiceDateTime.Contains(searchTerm))
							result.Add(invoiceList[i]);
					break;
				
				default:
					return result;
			}

			return result;
		}
	}
}
