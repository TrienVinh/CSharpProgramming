using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;
using System.Collections.Generic;

namespace DoAnGiuaKy.BUS
{
    public class RouteBUS
    {
        public List<RouteDTO> routeList { get; private set; } = RouteDAO.SelectAll();

        public void ReloadList()
        {
            routeList.Clear();
            routeList = RouteDAO.SelectAll();
        }

        public RouteDTO Get(string id)
        {
            for(int i = 0; i < routeList.Count; i++)
                if (routeList[i].RouteID.ToLower().Equals(i.ToString()))
                    return routeList[i];

            return null;
        }

        public void Insert(RouteDTO target)
        {
            routeList.Add(target);
            RouteDAO.Insert(target);
        }

        public void Update(RouteDTO target)
        {
            for(int i = 0; i < routeList.Count; i++)
                if (routeList[i].RouteID.ToLower().Equals(target.RouteID.ToString()))
                {
                    //Update the list
                    routeList.Remove(routeList[i]);
                    routeList.Add(target);

                    //Update database
                    RouteDAO.Update(target);
                    return;
                }
        }

        public void Delete(string id)
        {
            for (int i = 0; i < routeList.Count; i++)
                if (routeList[i].RouteID.ToLower().Equals(id.ToLower()))
                {
                    routeList.Remove(routeList[i]);
                    RouteDAO.Delete(id);
                    return;
                }
        }

        public List<RouteDTO> Search(string id, string departureLocation, string arrivalLocation)
        {
            List<RouteDTO> result = new List<RouteDTO>();

            id = id.ToLower().Trim();
            departureLocation= departureLocation.ToLower().Trim();
            arrivalLocation= arrivalLocation.ToLower().Trim();

            for (int i = 0; i < routeList.Count; i++)
                if (routeList[i].RouteID.ToLower().Contains(id) &&
                    routeList[i].departureLocation.ToLower().Contains(departureLocation) &&
                    routeList[i].arrivalLocation.ToLower().Contains(arrivalLocation))

                    result.Add(routeList[i]);

            return result;
        }
    }
}
