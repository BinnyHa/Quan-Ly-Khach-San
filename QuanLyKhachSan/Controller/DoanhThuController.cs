using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;

namespace QuanLyKhachSan.Controller
{
    public class DoanhThuController
    {
        ChuanHoa ch = new ChuanHoa();
        HotelObject.ThanhToanHo tt = new HotelObject.ThanhToanHo();
        Connection conn = new Connection();
        string sophong = "0";
        public void DoanhThuTong(BunifuiOSSwitch switchdoanhthu, BunifuDatepicker DPDoanhThu, Label lbdtdatphong, Label lbsophong, Label lbdichvu)
        {

            string day, month, year;

            if (switchdoanhthu.Value == true)
            {
                ch.ChuanHoaDate(DPDoanhThu.Value.ToString(), out day, out month, out year);
                tt.ThanhTien = conn.LayBien("EXEC PROC_SELECT_TONGTIEN '" + year + month + day + "'", 0);
                sophong = conn.LayBien("EXEC PROC_SELECT_SOPHONG '" + year + month + day + "'", 0);
                if (tt.ThanhTien == "")
                {
                    tt.ThanhTien = "0";
                }
                lbdtdatphong.Text = (Int32.Parse(tt.ThanhTien)).ToString();
                lbsophong.Text = sophong;
            }
            else
            {
                tt.ThanhTien = conn.LayBien("EXEC PROC_SELECT_TONGTIEN1", 0);
                sophong = conn.LayBien("EXEC PROC_SELECT_SOPHONG1", 0);
                if (tt.ThanhTien == "")
                {
                    tt.ThanhTien = "0";
                }
                lbdtdatphong.Text = (Int32.Parse(tt.ThanhTien)).ToString();
                lbsophong.Text = sophong;
            }
        }
        public void DoanhThuTong1(BunifuiOSSwitch switchdoanhthu, BunifuDatepicker DPDoanhThu, Label lbdtdatphong, Label lbsophong, Label lbdichvu)
        {
            string day, month, year;
            if (switchdoanhthu.Value == true)
            {
                ch.ChuanHoaDate(DPDoanhThu.Value.ToString(), out day, out month, out year);
                tt.ThanhTien = conn.LayBien("EXEC PROC_SELECT_TONGTIEN '" + year + month + day + "'", 0);
                sophong = conn.LayBien("EXEC PROC_SELECT_SOPHONG '" + year + month + day + "'", 0);
                if (tt.ThanhTien == "")
                {
                    tt.ThanhTien = "0";
                }
                lbdtdatphong.Text = (Int32.Parse(tt.ThanhTien)).ToString();
                lbsophong.Text = sophong;
            }
        }
        string day, month, year, month1, year1;
        public void DoanhThuPhong(Label lbslktthangtruoc, Label lbslktthangnay, BunifuProgressBar PBslkhachtang, BunifuProgressBar PBslkhachtang1)
        {
            ch.ChuanHoaDate(DateTime.Now.ToString(), out day, out month, out year);
            string slktthangtruoc = "0";
            string slktthangnay = "0";
            if (month=="1")
            {
                month1 = "12";
                year1= (Convert.ToInt32(year) - 1).ToString();
            }
            else
            {
                month1 = (Convert.ToInt32(month) - 1).ToString();
                year1 = year;
            }
            int lastDayOfMonth = DateTime.DaysInMonth(Convert.ToInt32(year1), Convert.ToInt32(month1));
            slktthangnay = conn.LayBien("EXEC PROC_DoanhThuPhong '" + year + "-" + month + "-1','" + year + "-" + month + "-" + day + "'", 0);
            slktthangtruoc = conn.LayBien("EXEC PROC_DoanhThuPhong '" + year1 + "-" + month1 + "-1','" + year1 + "-" + month1 + "-" + lastDayOfMonth + "'", 0);
            if (slktthangtruoc == null)
            {
                slktthangtruoc = "0";
            }
            if (slktthangnay == null)
            {
                slktthangnay = "0";
            }
            lbslktthangtruoc.Text = slktthangtruoc;
            lbslktthangnay.Text = slktthangnay;
            if (Convert.ToInt32(slktthangtruoc) < Convert.ToInt32(slktthangnay))
            {
                PBslkhachtang.Value = Convert.ToInt32((Convert.ToDouble(slktthangtruoc) / Convert.ToDouble(slktthangnay)) * 100);
                PBslkhachtang1.Value = 100;
            }
            else if (Convert.ToInt32(slktthangtruoc) > Convert.ToInt32(slktthangnay))
            {
                PBslkhachtang1.Value = Convert.ToInt32((Convert.ToDouble(slktthangnay) / Convert.ToDouble(slktthangtruoc)) * 100);
                PBslkhachtang.Value = 100;
            }
            else
            {
                PBslkhachtang.Value = 100;
                PBslkhachtang1.Value = 100;
            }
        }
        public void TyLeSoLuongKhach(Label lbslktthangtruoc,Label lbslktthangnay, BunifuProgressBar PBslkhachtang, BunifuProgressBar PBslkhachtang1)
        {
            ch.ChuanHoaDate(DateTime.Now.ToString(), out day, out month, out year);
            string slktthangtruoc = "0";
            string slktthangnay = "0";
            if (month == "1")
            {
                month1 = "12";
                year1 = (Convert.ToInt32(year) - 1).ToString();
            }
            else
            {
                month1 = (Convert.ToInt32(month) - 1).ToString();
                year1 = year;
            }
            int lastDayOfMonth = DateTime.DaysInMonth(Convert.ToInt32(year1), Convert.ToInt32(month1));
            slktthangnay = conn.LayBien("EXEC PROC_TLSOLUONGKHACH '" + year + "-" + month + "-1','" + year + "-" + month + "-" + day + "'", 0);
            slktthangtruoc = conn.LayBien("EXEC PROC_TLSOLUONGKHACH '" + year1 + "-" + month1 + "-1','" + year1 + "-" + month1 + "-" + lastDayOfMonth + "'", 0);
            if(slktthangtruoc == null)
            {
                slktthangtruoc = "0";
            }
            if (slktthangnay == null)
            {
                slktthangnay = "0";
            }
            lbslktthangtruoc.Text = slktthangtruoc;
            lbslktthangnay.Text = slktthangnay;
            if(Convert.ToInt32(slktthangtruoc) < Convert.ToInt32(slktthangnay))
            {
                PBslkhachtang.Value = Convert.ToInt32((Convert.ToDouble(slktthangtruoc) / Convert.ToDouble(slktthangnay)) * 100);
                PBslkhachtang1.Value = 100;
            }
            else if (Convert.ToInt32(slktthangtruoc) > Convert.ToInt32(slktthangnay))
            {
                PBslkhachtang1.Value = (Convert.ToInt32(slktthangnay) / Convert.ToInt32(slktthangtruoc)) * 100;
                PBslkhachtang.Value = 100;
            }
            else
            {
                PBslkhachtang.Value = 100;
                PBslkhachtang1.Value = 100;
            }
        }
        public void DoanhThuDichVu(Label lbdtdvthangtrc, Label lbdtdvthangnay, BunifuProgressBar Pbdtdv, BunifuProgressBar Pbdtdv1)
        {
            ch.ChuanHoaDate(DateTime.Now.ToString(), out day, out month, out year);
            string slktthangtruoc = "0";
            string slktthangnay = "0";
            if (month == "1")
            {
                month1 = "12";
                year1 = (Convert.ToInt32(year) - 1).ToString();
            }
            else
            {
                month1 = (Convert.ToInt32(month) - 1).ToString();
            }
            int lastDayOfMonth = DateTime.DaysInMonth(Convert.ToInt32(year1), Convert.ToInt32(month1));
            slktthangnay = conn.LayBien("EXEC PROC_DoanhThuDichVu '" + year + "-" + month + "-1','" + year + "-" + month + "-" + day + "'", 0);
            slktthangtruoc = conn.LayBien("EXEC PROC_DoanhThuDichVu '" + year1 + "-" + month1 + "-1','" + year1 + "-" + month1 + "-" + lastDayOfMonth + "'", 0);
            if (slktthangtruoc == null)
            {
                slktthangtruoc = "0";
            }
            if (slktthangnay == null)
            {
                slktthangnay = "0";
            }
            lbdtdvthangtrc.Text = slktthangtruoc;
            lbdtdvthangnay.Text = slktthangnay;
            if (Convert.ToInt32(slktthangtruoc) < Convert.ToInt32(slktthangnay))
            {
                Pbdtdv.Value = Convert.ToInt32((Convert.ToDouble(slktthangtruoc) / Convert.ToDouble(slktthangnay)) * 100);
                Pbdtdv1.Value = 100;
            }
            else if (Convert.ToInt32(slktthangtruoc) > Convert.ToInt32(slktthangnay))
            {
                Pbdtdv1.Value = Convert.ToInt32((Convert.ToDouble(slktthangnay) / Convert.ToDouble(slktthangtruoc)) * 100);
                Pbdtdv.Value = 100;
            }
            else
            {
                Pbdtdv.Value = 100;
                Pbdtdv1.Value = 100;
            }
        }
    }
}
