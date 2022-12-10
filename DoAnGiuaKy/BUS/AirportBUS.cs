using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;
using System.Collections.Generic;

namespace DoAnGiuaKy.BUS
{
	public class AirportBUS
	{
		public List<AirportDTO> airportList { get; private set; } = AirportDAO.SelectAll();

		public void ReloadList()
		{
			airportList.Clear();
			airportList = AirportDAO.SelectAll();
		}

		public AirportDTO Get(string id)
		{
			for (int i = 0; i < airportList.Count; i++)
				if (airportList[i].airportID.ToLower().Equals(id.ToLower()))
					return airportList[i];

			return null;
		}

		public void Insert(AirportDTO target)
		{
			airportList.Add(target);
			AirportDAO.Insert(target);
		}

		public void Update(AirportDTO target)
		{
			for (int i = 0; i < airportList.Count; i++)
				if (airportList[i].airportID.ToLower().Equals(target.airportID.ToLower()))
				{
					// Update the list.
					airportList.Remove(airportList[i]);
					airportList.Add(target);

					// Update the database.
					AirportDAO.Update(target);
					return;
				}
		}

		public void Delete(string id)
		{
			for (int i = 0; i < airportList.Count; i++)
				if (airportList[i].airportID.ToLower().Equals(id.ToLower()))
				{
					airportList.Remove(airportList[i]);
					AirportDAO.Delete(id);
					return;
				}
		}

		public List<AirportDTO> Search(int tieuChiIndex, string searchTerm)
		{
			List<AirportDTO> result = new List<AirportDTO>();

			searchTerm = searchTerm.ToLower().Trim();

			switch (tieuChiIndex)
			{
				// Airport ID.
				case 0:
					for (int i = 0; i < airportList.Count; i++)
						if (airportList[i].airportID.ToLower().Contains(searchTerm))
							result.Add(airportList[i]);
					break;

				// Airport Name.
				case 1:
					for (int i = 0; i < airportList.Count; i++)
						if (airportList[i].airportName.ToLower().Contains(searchTerm))
							result.Add(airportList[i]);
					break;

				// Airport City.
				case 2:
					for (int i = 0; i < airportList.Count; i++)
						if (airportList[i].airportCity.ToLower().Contains(searchTerm))
							result.Add(airportList[i]);
					break;

				default:
					return airportList;
			}

			return result;
		}
	}
}
