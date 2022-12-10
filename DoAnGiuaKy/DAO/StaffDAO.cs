using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;

namespace DoAnGiuaKy.DAO
{
	public class StaffDAO
	{
		public static List<StaffDTO> SelectAll()
		{
			List<StaffDTO> staffList = new List<StaffDTO>();
			Connection conn = new Connection();

			string queryStr = "select * from staff";
			DataTable result = conn.Execute(queryStr);

			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				string staffID = datarow.ItemArray[0].ToString();
				string staffLast = datarow.ItemArray[1].ToString();
				string staffFirst = datarow.ItemArray[2].ToString();
				string staffGender = datarow.ItemArray[3].ToString();
				string staffBirth = datarow.ItemArray[4].ToString();
				string staffAddress = datarow.ItemArray[5].ToString();
				string staffPhone = datarow.ItemArray[6].ToString();

				StaffDTO invoice = new StaffDTO(staffID, staffLast, staffFirst, staffGender, staffBirth, staffAddress, staffPhone);
				staffList.Add(invoice);
			}

			return staffList;
		}

		public static void Insert(StaffDTO target)
		{
			Connection conn = new Connection();
			
			string insertStr = $"insert into staff (staffID, staffLast, staffFirst, staffGender, staffBirth, staffAddress, staffTelephone) " +
				$"values ('{target.staffID}', N'{target.staffLast}', N'{target.staffFirst}', N'{target.staffGender}', " +
						$"'{target.staffBirth}', N'{target.staffAddress}', '{target.staffTelephone}')";
			
			conn.ExecuteNonQuery(insertStr);
		}

		public static void Update(StaffDTO target)
		{
			Connection conn = new Connection();

			string updateStr = "update staff set ";
			updateStr += $"staffID = '{target.staffID}', ";
			updateStr += $"staffLast = N'{target.staffLast}', ";
			updateStr += $"staffFirst = N'{target.staffFirst}', ";
			updateStr += $"staffGender = N'{target.staffGender}', ";
			updateStr += $"staffBirth = '{target.staffBirth}', ";
			updateStr += $"staffAddress = N'{target.staffAddress}', ";
			updateStr += $"staffTelephone = '{target.staffTelephone}' ";
			updateStr += $"where staffID = '{target.staffID}'";

			conn.ExecuteNonQuery(updateStr);
		}

		public static void Delete(string id)
		{
			Connection conn = new Connection();
			string deleteStr = $"delete from staff where staffID = '{id}'";
			conn.ExecuteNonQuery(deleteStr);
		}
	}
}
