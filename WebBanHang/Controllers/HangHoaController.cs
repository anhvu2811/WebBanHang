using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class HangHoaController : Controller
    {
        QLThietBiDienTuDataContext db = new QLThietBiDienTuDataContext();
        public ActionResult showHangHoa()
        {
            var listHangHoa = db.HangHoas.ToList();
            return View(listHangHoa);
        }
        public ActionResult HangHoa_TrangChu()
        {
            var listHangHoa = db.HangHoas.Take(5).OrderBy(cd => cd.TenHH).ToList();
            return View(listHangHoa);
        }
        public ActionResult XemChiTiet(int ma)
        {
            HangHoa hanghoa = new HangHoa();
            hanghoa = db.HangHoas.Single(s => s.MaHH == ma);
            if (hanghoa == null)
            {
                return HttpNotFound();
            }
            return View(hanghoa);
        }
        public ActionResult SearchSanPham(string txt_search)
        {
            ConnectHangHoa obj = new ConnectHangHoa();
            List<HangHoa> listSP = obj.Search(txt_search);
            ViewBag.Tong = listSP.Count();
            return View(listSP);
        }

        //Danh sách, Thêm, xóa, sửa bảng Hàng Hóa
        public ActionResult Index()
        {
            var listHangHoa = from x in db.HangHoas select x;
            return View(listHangHoa);
        }
        public ActionResult Details(int id)
        {
            var listHangHoa = db.HangHoas.Single(x => x.MaHH == id);
            return View(listHangHoa);
        }
        public ActionResult Create()
        {
            var nhomHangSelect = new SelectList(db.NhomHangs, "MaNhom", "TenNhom");
            ViewBag.MaNhom = nhomHangSelect;
            return View();
        }
        [HttpPost]
        public ActionResult Create(HangHoa hanghoa, HttpPostedFileBase image)
        {
            try
            {
                if (image != null)
                {
                    hanghoa.HinhAnh = image.FileName;
                    string _FileName = Path.GetFileName(image.FileName);
                    string _path = Path.Combine(Server.MapPath("~/Images"), _FileName);
                    image.SaveAs(_path);
                }
                db.HangHoas.InsertOnSubmit(hanghoa);
                db.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var listHangHoa = db.HangHoas.Single(x => x.MaHH == id);
            var nhomHangSelect = new SelectList(db.NhomHangs, "MaNhom", "TenNhom");
            ViewBag.MaNhom = nhomHangSelect;
            return View(listHangHoa);
        }
        [HttpPost]
        public ActionResult Edit(int id, HangHoa hh, HttpPostedFileBase image)
        {

            try
            {
                HangHoa hanghoa = db.HangHoas.Single(x => x.MaHH == id);
                hanghoa.MaNhom = hh.MaNhom;
                hanghoa.TenHH = hh.TenHH;
                hanghoa.HinhAnh = hh.HinhAnh;
                hanghoa.Gia = hh.Gia;
                hanghoa.DonViTinh = hh.DonViTinh;
                hanghoa.NoiSX = hh.NoiSX;

                hanghoa.HinhAnh = image.FileName;
                string _FileName = Path.GetFileName(image.FileName);
                string _path = Path.Combine(Server.MapPath("~/Images"), _FileName);
                image.SaveAs(_path);

                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            var listHangHoa = db.HangHoas.Single(x => x.MaHH == id);
            return View(listHangHoa);
        }
        [HttpPost]
        public ActionResult Delete(int id, HangHoa hh)
        {
            try
            {
                var hanghoa = db.HangHoas.Single(x => x.MaHH == id);
                db.HangHoas.DeleteOnSubmit(hanghoa);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}