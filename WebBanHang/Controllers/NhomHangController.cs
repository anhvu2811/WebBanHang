using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class NhomHangController : Controller
    {
        // GET: NhomHang
        QLThietBiDienTuDataContext db = new QLThietBiDienTuDataContext();
        public ActionResult showNhomHang()
        {
            var listNhomHang = db.NhomHangs.OrderBy(cd => cd.TenNhom).ToList();
            return View(listNhomHang);
        }
        public ActionResult hanghoaTheoNhomHang(int MaNhom)
        {
            var listHangHoa = db.HangHoas.Where(s => s.MaNhom == MaNhom).OrderBy(s => s.Gia).ToList();
            if (listHangHoa.Count == 0)
            {
                ViewBag.Sach = "Không có hàng hóa nào thuộc danh mục này !";
            }
            return View(listHangHoa);
        }
        //Danh sách, Thêm, xóa, sửa bảng Nhóm Hàng
        public ActionResult Index()
        {
            var listNhomHang = from x in db.NhomHangs select x;
            return View(listNhomHang);
        }
        public ActionResult Details(int id)
        {
            var listNhomHang = db.NhomHangs.Single(x => x.MaNhom == id);
            return View(listNhomHang);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(NhomHang nhomHang)
        {
            try
            {
                db.NhomHangs.InsertOnSubmit(nhomHang);
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
            var listNhomHang = db.NhomHangs.Single(x => x.MaNhom == id);
            return View(listNhomHang);
        }
        [HttpPost]
        public ActionResult Edit(int id, NhomHang nh)
        {

            try
            {
                NhomHang nhomHang = db.NhomHangs.Single(x => x.MaNhom == id);
                nhomHang.TenNhom = nh.TenNhom;

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
            var listNhomHang = db.NhomHangs.Single(x => x.MaNhom == id);
            return View(listNhomHang);
        }
        [HttpPost]
        public ActionResult Delete(int id, NhomHang nh)
        {
            try
            {
                var nhomhang = db.NhomHangs.Single(x => x.MaNhom == id);
                db.NhomHangs.DeleteOnSubmit(nhomhang);
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