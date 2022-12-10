using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;
using System.Collections.Generic;

namespace DoAnGiuaKy.BUS
{
	public class FlightScheduleBUS
	{
		public List<FlightScheduleDTO> fsList { get; private set; } = FlightScheduleDAO.SelectAll();

		public void ReloadList()
		{
			fsList.Clear();
			fsList = FlightScheduleDAO.SelectAll();
		}

		public FlightScheduleDTO Get(string id)
		{
			for (int i = 0; i < fsList.Count; i++)
				if (fsList[i].flightScheduleID.ToLower().Equals(id.ToLower()))
					return fsList[i];

			return null;
		}

		public void Insert(FlightScheduleDTO target)
		{
			fsList.Add(target);
			FlightScheduleDAO.Insert(target);
		}

		public void Update(FlightScheduleDTO target)
		{
			for (int i = 0; i < fsList.Count; i++)
				if (fsList[i].flightScheduleID.ToLower().Equals(target.flightScheduleID.ToLower()))
				{
					// Update the list.
					fsList.Remove(fsList[i]);
					fsList.Add(target);

					// Update the database.
					FlightScheduleDAO.Update(target);
					return;
				}
		}

		public void Delete(string id)
		{
			for (int i = 0; i < fsList.Count; i++)
				if (fsList[i].flightScheduleID.ToLower().Equals(id.ToLower()))
				{
					fsList.Remove(fsList[i]);
					FlightScheduleDAO.Delete(id);
					return;
				}
		}

		public List<FlightScheduleDTO> Search(int tieuChiIndex, string searchTerm)
		{
			List<FlightScheduleDTO> result = new List<FlightScheduleDTO>();

			searchTerm = searchTerm.ToLower().Trim();

			switch (tieuChiIndex)
			{
				// Flight Schedule ID.
				case 0:
					for (int i = 0; i < fsList.Count; i++)
						if (fsList[i].flightScheduleID.ToLower().Contains(searchTerm))
							result.Add(fsList[i]);
					break;

				// Departure Airport.
				case 1:
					for (int i = 0; i < fsList.Count; i++)
						if (fsList[i].departureAirport.ToLower().Contains(searchTerm))
							result.Add(fsList[i]);
					break;

				// Arrival Airport.
				case 2:
					for (int i = 0; i < fsList.Count; i++)
						if (fsList[i].arrivalAirport.ToLower().Contains(searchTerm))
							result.Add(fsList[i]);
					break;

				// Weekdays.
				case 3:
					for (int i = 0; i < fsList.Count; i++)
						if (fsList[i].weekdays.ToString().Contains(searchTerm))
							result.Add(fsList[i]);
					break;

				// Time.
				case 4:
					for (int i = 0; i < fsList.Count; i++)
						if (fsList[i].time.Contains(searchTerm))
							result.Add(fsList[i]);
					break;

				default:
					return fsList;
			}

			return result;
		}
	}
}
