namespace DoAnGiuaKy.DTO
{
	public class StaffDTO
	{
		public string staffID { get; set; }
		public string staffLast { get; set; }
		public string staffFirst { get; set; }
		public string staffGender { get; set; }
		public string staffBirth { get; set; }
		public string staffAddress { get; set; }
		public string staffTelephone { get; set; }

		public StaffDTO(string staffID, string staffLast, string staffFirst, string staffGender, string staffBirth, string staffAddress, string staffTelephone)
		{
			this.staffID = staffID;
			this.staffLast = staffLast;
			this.staffFirst = staffFirst;
			this.staffGender = staffGender;
			this.staffBirth = staffBirth;
			this.staffAddress = staffAddress;
			this.staffTelephone = staffTelephone;
		}
	}
}
