//using DoAnGiuaKy.DAO;
//using DoAnGiuaKy.DTO;
using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;
using System.Collections.Generic;

//namespace DoAnGiuaKy.BUS
namespace DoAnGiuaKy.BUS
{
	public class StaffBUS
	{
		// Object's DTOs list.
		public List<StaffDTO> staffList { get; private set; } = StaffDAO.SelectAll();

		public void ReloadList()
		{
			staffList.Clear();
			staffList = StaffDAO.SelectAll();
		}

		public StaffDTO Get(string id)
		{
			for (int i = 0; i < staffList.Count; i++)
				if (staffList[i].staffID.ToLower().Equals(id.ToLower()))
					return staffList[i];

			return null;
		}

		public void Insert(StaffDTO target)
		{
			staffList.Add(target);
			StaffDAO.Insert(target);
		}

		public void Update(StaffDTO target)
		{
			for (int i = 0; i < staffList.Count; i++)
				if (staffList[i].staffID.ToLower().Equals(target.staffID.ToLower()))
				{
					// Update the list.
					staffList.Remove(staffList[i]);
					staffList.Add(target);

					// Update the database.
					StaffDAO.Update(target);
					return;
				}
		}

		public void Delete(string id)
		{
			for (int i = 0; i < staffList.Count; i++)
				if (staffList[i].staffID.ToLower().Equals(id.ToLower()))
				{
					staffList.Remove(staffList[i]);
					StaffDAO.Delete(id);
					return;
				}
		}

		public List<StaffDTO> Search(int tieuChiIndex, string searchTerm, string gender)
		{
			List<StaffDTO> result = new List<StaffDTO>();

			searchTerm = searchTerm.ToLower().Trim();
			gender = gender.ToLower();

			switch (tieuChiIndex)
			{
				// Staff ID.
				case 0:
					for (int i = 0; i < staffList.Count; i++)
						if (staffList[i].staffID.ToLower().Contains(searchTerm) &&
							staffList[i].staffGender.ToLower().Equals(gender))
							result.Add(staffList[i]);
					break;

				// Staff Last.
				case 1:
					for (int i = 0; i < staffList.Count; i++)
						if (staffList[i].staffLast.ToLower().Contains(searchTerm) &&
							staffList[i].staffGender.ToLower().Equals(gender))
							result.Add(staffList[i]);
					break;

				// Staff First.
				case 2:
					for (int i = 0; i < staffList.Count; i++)
						if (staffList[i].staffFirst.ToLower().Contains(searchTerm) &&
							staffList[i].staffGender.ToLower().Equals(gender))
							result.Add(staffList[i]);
					break;

				// Birth.
				case 3:
					for (int i = 0; i < staffList.Count; i++)
						if (staffList[i].staffBirth.ToLower().Contains(searchTerm) &&
							staffList[i].staffGender.ToLower().Equals(gender))
							result.Add(staffList[i]);
					break;

				// Address.
				case 4:
					for (int i = 0; i < staffList.Count; i++)
						if (staffList[i].staffAddress.ToLower().Contains(searchTerm) &&
							staffList[i].staffGender.ToLower().Equals(gender))
							result.Add(staffList[i]);
					break;
				
				// Telephone.
				case 5:
					for (int i = 0; i < staffList.Count; i++)
						if (staffList[i].staffTelephone.Contains(searchTerm) &&
							staffList[i].staffGender.ToLower().Equals(gender))
							result.Add(staffList[i]);
					break;
				
				default:
					return result;
			}

			return result;
		}
	}
}
