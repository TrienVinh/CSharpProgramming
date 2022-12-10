namespace DoAnGiuaKy.DTO
{
	public class FlightScheduleDTO
	{
		public string flightScheduleID { get; set; }
		public string departureAirport { get; set; }
		public string arrivalAirport { get; set; }
		public string weekdays { get; set; }
		public string time { get; set; }

		public FlightScheduleDTO(string flightScheduleID, string departureAirport, string arrivalAirport, string weekdays, string time)
		{
			this.flightScheduleID = flightScheduleID;
			this.departureAirport = departureAirport;
			this.arrivalAirport = arrivalAirport;
			this.weekdays = weekdays;
			this.time = time;
		}
	}
}

