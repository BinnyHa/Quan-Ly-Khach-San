using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Layout
{
    public partial class QLPhong : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QLKS;Integrated Security=True");
        SqlDataAdapter adapt;
        public QLPhong()
        {
            InitializeComponent();
        }

        public void DisplayData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RQCS9A5\BIENCUTE;Initial Catalog=QLKS;Integrated Security=True");
            SqlDataAdapter adapt;
            SqlCommand cmdDV;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[phong]", con);
            adapt.Fill(dt);
            dataPhong.DataSource = dt;
            con.Close();
        }

        private void btthemdichvu_Click(object sender, EventArgs e)
        {
            SubLayout.FormThemDichVuPhong ftdvp = new SubLayout.FormThemDichVuPhong();
            ftdvp.ShowDialog();
            DisplayData();
        }

        private void QLPhong_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.PHONG  where MAPHONG like N'%" + txtTimkiem.Text +
                "%' or TENPHONG like N'%" + txtTimkiem.Text + "%' or GIATHUE like N'%" + txtTimkiem.Text + "%' or MALOAI like N'%" + txtTimkiem.Text + "%' or SOTANG like N'%" + txtTimkiem.Text + "%'", con);
            adapt.Fill(dt);
            dataPhong.DataSource = dt;
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
