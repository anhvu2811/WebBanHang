using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class NhanVienController : Controller
    {
        QLThietBiDienTuDataContext db = new QLThietBiDienTuDataContext();
        // GET: NhanVien
        public ActionResult Index()
        {
            var listNhanVien = from x in db.NhanViens select x;
            return View(listNhanVien);
        }
        public ActionResult Details(string id)
        {
            var listNhanVien = db.NhanViens.Single(x => x.MaNV == id);
            return View(listNhanVien);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(NhanVien nhanvien)
        {
            try
            {
                db.NhanViens.InsertOnSubmit(nhanvien);
                db.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(string id)
        {
            var listNhanVien = db.NhanViens.Single(x => x.MaNV == id);
            return View(listNhanVien);
        }
        [HttpPost]
        public ActionResult Edit(string id, NhanVien nv)
        {

            try
            {
                NhanVien nhanvien = db.NhanViens.Single(x => x.MaNV == id);
                nhanvien.TenNV = nv.TenNV;
                nhanvien.TaiKhoan = nv.TaiKhoan;
                nhanvien.Password = nv.Password;

                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(string id)
        {
            var listNhanVien = db.NhanViens.Single(x => x.MaNV == id);
            return View(listNhanVien);
        }
        [HttpPost]
        public ActionResult Delete(string id, NhanVien nv)
        {
            try
            {
                var nhanvien = db.NhanViens.Single(x => x.MaNV == id);
                db.NhanViens.DeleteOnSubmit(nhanvien);
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