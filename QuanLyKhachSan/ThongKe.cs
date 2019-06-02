using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class ThongKe
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
        SqlCommand cmdTK;
        public string getDta(string strsql)
        {
            string temp = null;
            con.Open();
            cmdTK = new SqlCommand(strsql, con);
            SqlDataReader dta = cmdTK.ExecuteReader();
            if (dta.Read() && dta.GetValue(0).ToString() != "")
            {
                temp = dta[0].ToString();
            }
            con.Close();
            return temp;
        }
    }
}
