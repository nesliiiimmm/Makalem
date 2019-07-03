using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Makalem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Makalem.Controllers
{
   
    public class SigninController : Controller
    {
        MakaleAraBulContext mabc = new MakaleAraBulContext();
        [HttpGet]
        public ActionResult Signin()
        {
            var klnc = mabc.Kullanici;

            ViewData["info"] = "";
            return View(klnc);
        }

        [HttpPost]
        public ActionResult Signin(string email, string password)
        {

            if (mabc.Kullanici.Where(i => i.Email == email && i.Sifre == password).Any())
            {
                Kullanici giris = mabc.Kullanici.FirstOrDefault(i => i.Email == email && i.Sifre == password);

                HttpContext.Session.SetString("Id",giris.Id.ToString());
                HttpContext.Session.SetString("Adi", giris.Adi.ToString());
                HttpContext.Session.SetString("Soyadi", giris.Soyadi.ToString());
                HttpContext.Session.SetString("Email", giris.Email.ToString());
                HttpContext.Session.SetString("KullaniciAdi", giris.KullaniciAdi.ToString());
                HttpContext.Session.SetString("KullaniciType", giris.KullaniciTipi.ToString());


                
                if (giris.KullaniciTipi == 2)
                {
                    return RedirectToAction("Index", "Admin");
                }
                
                return RedirectToAction("Index", "Home");
            }
            ViewData["info"] = "Yanlış email veya şifre girdiniz !";
            return View();
        }

        public ActionResult SignOut()
        {
            HttpContext.Session.Clear();
                
            return RedirectToAction("Index","Home");
        }

    }
}