using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Makalem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Makalem.Controllers
{
    public class AdminController : Controller
    {
        MakaleAraBulContext mabc = new MakaleAraBulContext();
        public IActionResult Index(Kullanici giris)
        {
            if (HttpContext.Session.GetString("KullaniciType") != "2")
            {
                return RedirectToAction("Index", "Home");
            }

            return View(giris);
        }

        public IActionResult Comment(int id, int cid)
        {
            Yorum cmt = mabc.Yorum.FirstOrDefault(İ => İ.Id == id);
            if (cid == 1)
            {
                mabc.Yorum.Remove(cmt);
                mabc.SaveChanges();

            }
            else if (cid == 2)
            {
                cmt.DurumTipi = true;
                mabc.Yorum.Update(cmt);
                mabc.SaveChanges();
            }

            IEnumerable<Yorum> com = mabc.Yorum;
            return View(com);
        }

        public IActionResult Usr(int id, byte type)
        {
            Kullanici kln = mabc.Kullanici.FirstOrDefault(i => i.Id == id);
            if (type == 0 && id != 0)
            {
                mabc.Kullanici.Remove(kln);
                mabc.SaveChanges();

            }
            else if (type == 2 || type == 1)
            {
                kln.KullaniciTipi = type;
                mabc.Kullanici.Update(kln);
                mabc.SaveChanges();
            }
            IEnumerable<Kullanici> klnc = mabc.Kullanici;
            return View(klnc);
        }

        public IActionResult Article(int id, int cid)
        {
            Makale mak = mabc.Makale.FirstOrDefault(i => i.Id == id);

            if (cid != 0)
            {
                mak.DurumTipi = true;
                mabc.Makale.Update(mak);
                mabc.SaveChanges();

            }
            else if (id != 0 )
            {
                IEnumerable<MakaleKategori> makcat = mabc.MakaleKategori.Where(i => i.MakaleId == id);
                mabc.RemoveRange(makcat);
                mabc.SaveChanges();

                IEnumerable<Yorum> makyor = mabc.Yorum.Where(i => i.MakaleId == id);
                mabc.RemoveRange(makyor);
                mabc.SaveChanges();

                mabc.Remove(mak);
                mabc.SaveChanges();
            }
            

            return View(mabc.Makale);
        }
    }
}