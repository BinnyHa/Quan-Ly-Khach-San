using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Layout.SubLayout
{
    public partial class ChiTietDV : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QLKS;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdDV;
        public ChiTietDV()
        {
            InitializeComponent();
        }

        
        public void LoadDV()
        {
            con.Open();
            DataTable dt = new DataTable();

            adapt = new SqlDataAdapter("SELECT * FROM dbo.SUDUNGDICHVU ", con);

            adapt.Fill(dt);
            dataSDDV.DataSource = dt;
            con.Close();
        }
        private void ChiTietDV_Load(object sender, EventArgs e)
        {

            LoadDV();
        }
    }
}
