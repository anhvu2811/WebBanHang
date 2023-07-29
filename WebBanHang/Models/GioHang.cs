using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanHang.Models;

namespace WebBanHang.Models
{
    public class GioHang
    {
        QLThietBiDienTuDataContext db = new QLThietBiDienTuDataContext();
        public int iMaHangHoa { set; get; }
        public string sTenHangHoa { set; get; }
        public string sHinhAnh { set; get; }
        public double dGia { set; get; }
        public int iSoLuong { set; get; }
        public double dThanhTien
        {
            get { return iSoLuong * dGia; }
        }
        public GioHang(int MaHH)
        {
            iMaHangHoa = MaHH;
            HangHoa hanghoa = db.HangHoas.Single(s => s.MaHH == iMaHangHoa);
            sTenHangHoa = hanghoa.TenHH;
            sHinhAnh = hanghoa.HinhAnh;
            dGia = double.Parse(hanghoa.Gia.ToString());
            iSoLuong = 1;
        }
    }
}