using DoAnGiuaKy.DTO;
using System.Collections.Generic;
using System.Data;

namespace DoAnGiuaKy.DAO
{
    public class CustomerDAO
    {
        public static List<CustomerDTO> SelectAll()
        {
            List<CustomerDTO> Customerlist = new List<CustomerDTO>();
            Connection conn = new Connection();

            string queryStr = "select * from customer";
            DataTable result = conn.Execute(queryStr);

            for(int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];

                string CustomerId = datarow.ItemArray[0].ToString();
                string CustomerLast = datarow.ItemArray[1].ToString();
                string CustomerFirst = datarow.ItemArray[2].ToString();
                string CustomerGender = datarow.ItemArray[3].ToString();
                int CustomerBirthday = int.Parse(datarow.ItemArray[4].ToString());
                string CustomerAddress =  datarow.ItemArray[5].ToString();
                string CustomerTelephone = datarow.ItemArray[6].ToString();

                CustomerDTO customer = new CustomerDTO(CustomerId, CustomerLast, CustomerFirst, CustomerGender, CustomerBirthday, CustomerAddress, CustomerTelephone);
                Customerlist.Add(customer);
            }
            return Customerlist;
        }

        public static void Insert(CustomerDTO target)
        {
            Connection conn = new Connection();
            string insertStr = $"insert into customer values ('{target.CustomerId}', N'{target.CustomerLast}', N'{target.CustomerFirst}', N'{target.CustomerGender}', "+
                $"'{target.CustomerBirthday}', N'{target.CustomerAddress}, '{target.CustomerTelephone}')";
            conn.ExecuteNonQuery(insertStr);
        }

        public static void Update(CustomerDTO target)
        {
            Connection conn = new Connection();

            string UpdateStr = "update customer set ";
            UpdateStr += $"customerID = '{target.CustomerId}', ";
            UpdateStr += $"customerLast = N'{target.CustomerLast}', ";
            UpdateStr += $"customerFirst = N'{target.CustomerFirst}', ";
            UpdateStr += $"customerGender = N'{target.CustomerGender}', ";
            UpdateStr += $"customerBirthday = '{target.CustomerBirthday}', ";
            UpdateStr += $"customerAddress = N'{target.CustomerAddress}', ";
            UpdateStr += $"customerTelephone = '{target.CustomerTelephone}'";
            UpdateStr += $"where customerID = '{target.CustomerId}'";

            conn.ExecuteNonQuery(UpdateStr);
        }

        public static void Delete(string id)
        {
            Connection conn = new Connection();
            string deleteStr = $"delete from customer where customerId = '{id}'";
            conn.ExecuteNonQuery(deleteStr);
        }
    }
}
