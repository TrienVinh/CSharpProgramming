using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;
using System.Collections.Generic;

namespace DoAnGiuaKy.BUS
{
    public class FlightBUS
    {
        public List<FlightDTO> flightList { get; private set; } = FlightDAO.SelectAll();

        public void Reloadlist()
        {
            flightList.Clear();
            flightList = FlightDAO.SelectAll();
        }

        public FlightDTO Get(string id)
        {
            for(int i = 0; i < flightList.Count; i++)
                if (flightList[i].FlightID.ToLower().Equals(i.ToString()))
                    return flightList[i];
            return null;
        }



        public void Insert(FlightDTO target)
        {
            flightList.Add(target);
            FlightDAO.Insert(target);
        }

        public void Update(FlightDTO target)
        {
            for (int i = 0; i < flightList.Count; i++)
                if (flightList[i].FlightID.ToLower().Equals(target.FlightID.ToLower()))
                {
                    //Update the list
                    flightList.Remove(flightList[i]);
                    flightList.Add(target);

                    //Update the database
                    FlightDAO.Update(target);
                    return;
                }
        }

        public void Delete(string id)
        {
            for (int i = 0; i < flightList.Count; i++)
                if (flightList[i].FlightID.ToLower().Equals(i.ToString()))
                    flightList.Remove(flightList[i]);
                    FlightDAO.Delete(id);
                    return;
        }

        public List<FlightDTO> Search(int TieuchiIndex, string searchTerm)
        {
            List<FlightDTO> result = new List<FlightDTO>();

            searchTerm = searchTerm.ToLower().Trim();
            

            switch (TieuchiIndex)
            {
                // Flight ID.
                case 0:
                    for (int i = 0; i < flightList.Count; i++)
                        if (flightList[i].FlightID.ToLower().Contains(searchTerm))
                            result.Add(flightList[i]);
                    break;

                // Route ID.
                case 1:
                    for (int i = 0; i < flightList.Count; i++)
                        if (flightList[i].RouteID.ToLower().Contains(searchTerm))
                            result.Add(flightList[i]);
                    break;

                // Airplane ID.
                case 2:
                    for (int i = 0; i < flightList.Count; i++)
                        if (flightList[i].airplaneID.ToLower().Contains(searchTerm))
                            result.Add(flightList[i]);
                    break;

                // flightScheduleID.
                case 3:
                    for (int i = 0; i < flightList.Count; i++)
                        if (flightList[i].flightScheduleID.ToString().Contains(searchTerm))
                            result.Add(flightList[i]);
                    break;

                // totalSeat.
                case 4:
                    for (int i = 0; i < flightList.Count; i++)
                        if (flightList[i].totalSeats.ToString().Contains(searchTerm))
                            result.Add(flightList[i]);
                    break;

                default:
                    return result;
            }

            return result;
        }
    }
}
