﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraPrinting;

namespace Phan_Mem_Quan_Ly_In_Tem
{
    public partial class rptInTemNuTrang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInTemNuTrang()
        {
            InitializeComponent();
            
            RequestParameters = false;
        }
        public rptInTemNuTrang(DataTable dt, string tenTiem, string diaChi)
        {
            InitializeComponent();
            
            if (dt != null)
            {
                dsDanhSachHangHoa1.InMaVach.Merge(dt);
            }

            TenTiem.Value = tenTiem;
            DiaChi.Value = diaChi;

            RequestParameters = false;
        }

        public rptInTemNuTrang(string tenTiem, string diaChi, string maVach, string tenHang, decimal tongTrongLuong, decimal trongLuong, decimal tienCong, decimal hot, string loaiVang, string nhaCungCap, string hamLuongPho, int soLuongTem, string tongTrongLuongChu, string trongLuongChu, string hotChu)
        {
            InitializeComponent();
            
            dsDanhSachHangHoa1.InMaVach.Rows.Clear();

            for(int i=0; i<soLuongTem; i++)
            {
                DataRow drDongIn = dsDanhSachHangHoa1.InMaVach.NewRow();

                drDongIn["MaVach"] = maVach;
                drDongIn["TenHang"] = tenHang;
                drDongIn["TongTrongLuong"] = tongTrongLuong;
                drDongIn["TrongLuong"] = trongLuong;
                drDongIn["TienCong"] = tienCong;
                drDongIn["Hot"] = hot;
                drDongIn["NhaCungCap"] = nhaCungCap;
                drDongIn["HamLuongPho"] = hamLuongPho;
                drDongIn["SoLuongTem"] = soLuongTem;

                drDongIn["TongTrongLuongChu"] = tongTrongLuongChu;
                drDongIn["TrongLuongChu"] = trongLuongChu;
                drDongIn["HotChu"] = hotChu;

                dsDanhSachHangHoa1.InMaVach.Rows.Add(drDongIn);
                dsDanhSachHangHoa1.InMaVach.AcceptChanges();
            }

            TenTiem.Value = tenTiem;
            DiaChi.Value = diaChi;
            RequestParameters = false;
        }

        private void rptInMaVach_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            base.OnAfterPrint(e);
        }

    }
}
