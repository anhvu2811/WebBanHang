using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class LoginController : Controller
    {
        QLThietBiDienTuDataContext db = new QLThietBiDienTuDataContext();
        // GET: Login}
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(NhanVien obj)
        {
            var data = db.NhanViens.Where(s => s.TaiKhoan == obj.TaiKhoan && s.Password == obj.Password).FirstOrDefault();
            if (data != null)
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    }
}