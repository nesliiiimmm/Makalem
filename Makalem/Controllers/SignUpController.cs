using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Makalem.Models;
using Microsoft.AspNetCore.Mvc;

namespace Makalem.Controllers
{
    public class SignUpController : Controller
    {
        MakaleAraBulContext mabc = new MakaleAraBulContext();
        [HttpGet]
        public IActionResult SignUp()
        {
            ViewData["pass"] = "";
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(string name,string surname,string email,string username, string password,string confirmpassword,byte usertype)
        {
            if (password.Equals(confirmpassword))
            {

                Kullanici klnc = new Kullanici();
                klnc.Adi = name;
                klnc.Soyadi = surname;
                klnc.Email = email;
                klnc.KullaniciAdi = username;
                klnc.Sifre = password;
                klnc.KullaniciTipi = usertype; // 0-reader  1- writer 2-admin
                klnc.DurumTipi = true;

                mabc.Kullanici.Add(klnc);
                mabc.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else {
                ViewData["pass"]="Şifre ve Şifre Tekrar'ı aynı değil. ";
            }

            return View();

          
        }

    }
}