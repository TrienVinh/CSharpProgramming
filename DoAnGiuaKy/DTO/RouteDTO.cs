namespace DoAnGiuaKy.DTO
{
    public class RouteDTO
    {
        public string RouteID { get; set; }
        public string departureLocation { get; set; }
        public string arrivalLocation { get; set; }

        public RouteDTO(string routeID, string departureLocation, string arrivalLocation)
        {
            this.RouteID = routeID;
            this.departureLocation = departureLocation;
            this.arrivalLocation = arrivalLocation;
        }
    }
}
