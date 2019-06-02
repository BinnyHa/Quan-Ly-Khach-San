using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Layout.SubLayout
{
    public partial class FormThanhToan : Form
    {
        string laytenphong;
        Connection conn = new Connection();
        public FormThanhToan(string tenphong, int sotang)
        {
            InitializeComponent();
            lbsotang.Text = sotang.ToString();
            lbtenphong.Text = tenphong;
            laytenphong = tenphong;

            HotelObject.ThuePhongHo tp = new HotelObject.ThuePhongHo();
            ChuanHoa ch = new ChuanHoa();
            HotelObject.SuDungDichVuHo sd = new HotelObject.SuDungDichVuHo();
            string year, month, day, ngayvao = null;
            string year1, month1, day1, ngayra = null;

            lbhoten.Text = conn.LayBien("EXEC PROC_SELECT_TENKHACHHANG N'" + lbtenphong.Text + "'", 0);
            lbloaiphong.Text = conn.LayBien("EXEC PROC_SELECT_LOAIPHONG N'" + lbtenphong.Text + "'", 0);
            tp.NgayVao = conn.LayBien("EXEC PROC_SELECT_NGAYVAO N'" + lbtenphong.Text + "'", 0);
            tp.NgayRa = conn.LayBien("EXEC PROC_SELECT_NGAYRA N'" + lbtenphong.Text + "'", 0);
           
            ch.ChuanHoaDate(tp.NgayRa, out day, out month, out year);
            ch.ChuanHoaDate(tp.NgayVao, out day1, out month1, out year1);
            
            lbngayvao.Text = day1 + " / " + month1 + " / " + year1;
            lbngayra.Text = day + " / " + month + " / " + year;

            string giatien = conn.LayBien("EXEC PROC_SELECT_GIATIEN N'" + lbtenphong.Text + "'", 0);
            string tongtientt = ch.TongTien(ngayra, ngayvao, Int32.Parse(giatien));

            sd.DonGia = conn.LayBien("EXEC PROC_SELECT_DONGIADV N'" + lbtenphong.Text + "'", 0);
            if (sd.DonGia == "")
            {
                sd.DonGia = "0";
            }
            lbdichvu.Text = sd.DonGia.ToString();

            TimeSpan time = DateTime.Parse(tp.NgayRa) - DateTime.Parse(tp.NgayVao);
            int dayz = time.Days + 1;
            lbthanhtien.Text = (Int32.Parse(tongtientt) * dayz).ToString();
            lbtongtien.Text = (Int32.Parse(sd.DonGia) + (Int32.Parse(tongtientt) * dayz)).ToString();
        }
       
        private void btthanhtoan_Click(object sender, EventArgs e)
        {
            HotelObject.ThuePhongHo tp = new HotelObject.ThuePhongHo();
            ChuanHoa ch = new ChuanHoa();
            string yearnow, monthnow, daynow;
            tp.MaThue = conn.LayBien("EXEC PROC_SELECT_MATHUE N'" + lbtenphong.Text + "'", 0);
            ch.ChuanHoaDate(DateTime.Now.ToString(), out daynow, out monthnow, out yearnow);
            conn.InsertDeleteUpdate("EXEC PROC_INSERT_THANHTOAN '" + tp.MaThue + "','" + lbtongtien.Text + "','" + yearnow + monthnow + daynow + "','" + UserInfo.ID + "'");
            conn.InsertDeleteUpdate("UPDATE THUEPHONG SET TRANGTHAI=0 WHERE MAPHONG IN (SELECT MAPHONG FROM PHONG WHERE TENPHONG='" + laytenphong + "')");
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
