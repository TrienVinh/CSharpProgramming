namespace DoAnGiuaKy.DTO
{
	public class CustomerDTO
	{
		public string CustomerId { get; set; }
		public string CustomerLast { get; set; }

		public string CustomerFirst { get; set; }
		public string CustomerGender { get; set; }
		public int CustomerBirthday { get; set; }
		public string CustomerAddress { get; set; }
		public string CustomerTelephone { get; set; }

		public CustomerDTO(string customerId, string customerLast, string customerFirst, string customerGender, int customerBirthday, string customerAddress, string customerTelephone)
		{
			this.CustomerId = customerId;
			this.CustomerLast = customerLast;
			this.CustomerFirst = customerFirst;
			this.CustomerGender = customerGender;
			this.CustomerBirthday = customerBirthday;
			this.CustomerAddress = customerAddress;
			this.CustomerTelephone = customerTelephone;
		}
	}
}
