namespace DoAnGiuaKy.DTO
{
    public class FlightDTO
    {
        public string FlightID { get; set; }
        public string RouteID { get; set; }
        public string airplaneID { get; set; }
        public string flightScheduleID { get; set; }
        public string departureDay { get; set; }
        public string arrivalDay { get; set; }
        public int totalSeats { get; set; }
        public int ECOSeats { get; set; }
        public int BUSSeats { get; set; }

        public FlightDTO(string flightID, string routeID, string airplaneID, string flightScheduleID, string departureDay, string arrivalDay, int totalSeats, int eCOSeats, int bUSSeats)
        {
            this.FlightID = flightID;
            this.RouteID = routeID;
            this.airplaneID = airplaneID;
            this.flightScheduleID = flightScheduleID;
            this.departureDay = departureDay;
            this.arrivalDay = arrivalDay;
            this.totalSeats = totalSeats;
            this.ECOSeats = eCOSeats;
            this.BUSSeats = bUSSeats;
        }
    }
}
