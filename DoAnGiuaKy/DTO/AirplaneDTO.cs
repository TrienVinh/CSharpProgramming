namespace DoAnGiuaKy.DTO
{
	public class AirplaneDTO
	{
		public string airplaneID { get; set; }
		public string airplaneName { get; set; }
		public string airplaneBrand { get; set; }
		public string airlineID { get; set; }
		public int ECOSeats { get; set; }
		public int BUSSeats { get; set; }

		public AirplaneDTO(string airplaneID, string airplaneName, string airplaneBrand, string airlineID, int ECOSeats, int BUSSeats)
		{
			this.airplaneID = airplaneID;
			this.airplaneName = airplaneName;
			this.airplaneBrand = airplaneBrand;
			this.airlineID = airlineID;
			this.ECOSeats = ECOSeats;
			this.BUSSeats = BUSSeats;
		}
	}
}
