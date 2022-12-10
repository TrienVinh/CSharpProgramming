namespace DoAnGiuaKy.DTO
{
	public class AirportDTO
	{
		public string airportID { get; set; }
		public string airportName { get; set; }
		public string airportCity { get; set; }

		public AirportDTO (string airportID, string airportName, string airportCity)
		{
			this.airportID = airportID;
			this.airportName = airportName;
			this.airportCity = airportCity;		
		}
	}
}	



