using System;
using System.Data;
using System.Data.SqlClient;
namespace DoAnGiuaKy.DAO
{
	public class Connection
	{
        SqlConnection sqlConn; //Doi tuong ket noi CSDL
        SqlDataAdapter da;//Bo dieu phoi du lieu
        DataSet ds;
		private string connection = "Data Source=DESKTOP-OTF5SVJ\\SQLEXPRESS;Initial Catalog=AirplaneTicketMngmtDB;Integrated Security=True";
		public Connection()
		{
            sqlConn = new SqlConnection(connection);
        }

        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open(); //Mo ket noi
            sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
            sqlConn.Close();//Dong ket noi
        }
    }
}