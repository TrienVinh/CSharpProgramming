namespace DoAnGiuaKy.DTO
{
	public class InvoiceDTO
	{
		public string invoiceID { get; set; }
		public string staffID { get; set; }
		public string customerID { get; set; }
		public int invoiceTotal { get; set; }
		public string invoiceDateTime { get; set; }

		public InvoiceDTO(string invoiceID, string staffID, string customerID, int invoiceTotal, string invoiceDateTime)
		{
			this.invoiceID = invoiceID;
			this.staffID = staffID;
			this.customerID = customerID;
			this.invoiceTotal = invoiceTotal;
			this.invoiceDateTime = invoiceDateTime;
		}
	}
}
