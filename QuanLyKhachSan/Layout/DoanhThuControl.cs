﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Layout
{
    public partial class DoanhThuControl : UserControl
    {
        Controller.DoanhThuController dtc = new Controller.DoanhThuController();
        public DoanhThuControl()
        {
            InitializeComponent();
            DPDoanhThu.Value = DateTime.Now;
           dtc.DoanhThuTong1(switchdoanhthu, DPDoanhThu, lbdtdatphong, lbsophong, lbdichvu);

            dtc.DoanhThuPhong(LBdtpthangtrc, LBdtpthangnay, PBdtpthangtrc, PBdtpthangnay);
            dtc.TyLeSoLuongKhach(LBsldpthangtrc, LBsldpthangnay, PBsldpthangtrc, PBsldpthangnay);
            dtc.DoanhThuDichVu(LBdtdvthangtrc, LBdtdvthangnay, Pbdtdvthangtrc, Pbdtdvthangnay);
        }

        private void switchdoanhthu_Change(object sender, EventArgs e)
        {
           dtc.DoanhThuTong(switchdoanhthu, DPDoanhThu, lbdtdatphong, lbsophong, lbdichvu);
        }

        private void DPDoanhThu_Change(object sender, EventArgs e)
        {
            dtc.DoanhThuTong1(switchdoanhthu, DPDoanhThu, lbdtdatphong, lbsophong, lbdichvu);
        }
    }
}
