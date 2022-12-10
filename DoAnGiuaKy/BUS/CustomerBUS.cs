using DoAnGiuaKy.DAO;
using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;

namespace DoAnGiuaKy.BUS
{
    public class CustomerBUS
    {
        public List<CustomerDTO> customerList { get; private set; } = CustomerDAO.SelectAll();

        public void Reloadlist()
        {
            customerList.Clear();
            customerList = CustomerDAO.SelectAll();
        }

        public CustomerDTO Get(string id)
        {
            for (int i = 0; i < customerList.Count; i++)
                if (customerList[i].CustomerId.ToLower().Equals(id.ToLower()))
                    return customerList[i];

            return null;
        }

        public DataTable GetCustomer()
        {
            DataTable dt = new Connection().Execute("select * from customer");
            return dt;
        }

        public void Insert(CustomerDTO target)
        {
            customerList.Add(target);
            CustomerDAO.Insert(target);
        }

        public void Update(CustomerDTO target)
        {
            for (int i = 0; i < customerList.Count; i++)
                if (customerList[i].CustomerId.ToLower().Equals(target.CustomerId.ToLower()))
                {
                    //Update the list
                    customerList.Remove(customerList[i]);
                    customerList.Add(target);

                    //Update the database
                    CustomerDAO.Update(target);
                    return;
                }
        }

        public void Delete(string id)
        {
            for (int i = 0; i < customerList.Count; i++)
                if (customerList[i].CustomerId.ToLower().Equals(id.ToLower()))
                {
                    customerList.Remove(customerList[i]);
                    CustomerDAO.Delete(id);
                    return;
                }
        }

        public List<CustomerDTO> Search(string last, string name, string birth, string gender)
        {
            List<CustomerDTO> result = new List<CustomerDTO>();

            last = last.Trim();
            name = name.Trim();
            gender = gender.Trim();
            birth = birth.ToString().Trim();

            for (int i = 0; i < customerList.Count; i++)
                if (customerList[i].CustomerLast.ToLower().Contains(last) &&
                    customerList[i].CustomerFirst.ToLower().Contains(name) &&
                    customerList[i].CustomerGender.ToLower().Contains(gender) &&
                    customerList[i].CustomerBirthday.ToString().Contains(birth))

                    result.Add(customerList[i]);

            return result;
        }
    }
}
