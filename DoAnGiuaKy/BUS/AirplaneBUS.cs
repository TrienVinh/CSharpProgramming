//using DoAnGiuaKy.DAO;
//using DoAnGiuaKy.DTO;
using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

//namespace DoAnGiuaKy.BUS
namespace DoAnGiuaKy.BUS
{
	public class AirplaneBUS
	{
		// Object's DTOs list.
		public List<AirplaneDTO> airplaneList { get; private set; } = AirplaneDAO.SelectAll();

		public void ReloadList()
		{
			airplaneList.Clear();
			airplaneList = AirplaneDAO.SelectAll();
		}

		public AirplaneDTO Get(string id)
		{
			for (int i = 0; i < airplaneList.Count; i++)
				if (airplaneList[i].airplaneID.ToLower().Equals(id.ToLower()))
					return airplaneList[i];

			return null;
		}

		public DataTable GetAirline()
		{
			DataTable dt = new Connection().Execute("select * from airline");
			return dt;
		}

		public void Insert(AirplaneDTO target)
		{
			airplaneList.Add(target);
			AirplaneDAO.Insert(target);
		}

		public void Update(AirplaneDTO target)
		{
			for (int i = 0; i < airplaneList.Count; i++)
				if (airplaneList[i].airplaneID.ToLower().Equals(target.airplaneID.ToLower()))
				{
					// Update the list.
					airplaneList.Remove(airplaneList[i]);
					airplaneList.Add(target);

					// Update the database.
					AirplaneDAO.Update(target);
					return;
				}
		}

		public void Delete(string id)
		{
			for (int i = 0; i < airplaneList.Count; i++)
				if (airplaneList[i].airplaneID.ToLower().Equals(id.ToLower()))
				{
					airplaneList.Remove(airplaneList[i]);
					AirplaneDAO.Delete(id);
					return;
				}
		}

		/// <summary>
		/// Search for a record by a combination of brand, ECO seats and BUS seats.
		/// </summary>
		/// <param name="brand"></param>
		/// <param name="ecoSeats"></param>
		/// <param name="busSeats"></param>
		/// <returns></returns>
		public List<AirplaneDTO> Search(string brand, string ecoSeats, string busSeats)
		{
			List<AirplaneDTO> result = new List<AirplaneDTO>();

			brand = brand.ToLower().Trim();
			ecoSeats = ecoSeats.Trim();
			busSeats = busSeats.Trim();

			// Every string always contains an empty string so if we don't write anything, it'll fetch all the record.
			for (int i = 0; i < airplaneList.Count; i++)
				if (airplaneList[i].airplaneBrand.ToLower().Contains(brand) &&
					airplaneList[i].ECOSeats.ToString().Contains(ecoSeats) &&
					airplaneList[i].BUSSeats.ToString().Contains(busSeats))
					
					result.Add(airplaneList[i]);

			return result;
		}
	}
}
