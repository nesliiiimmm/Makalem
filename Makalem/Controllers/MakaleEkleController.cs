using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Makalem.Models;
using Microsoft.AspNetCore.Http;

namespace Makalem.Controllers
{
    public class MakaleEkleController : Controller
    {
        MakaleAraBulContext mb = new MakaleAraBulContext();
        public IActionResult MakaleEkle()
        {
            if (HttpContext.Session.GetString("KullaniciType") == "0")
            {
                return RedirectToAction("Index", "Home");
            }

            IEnumerable<Kategori> k = mb.Kategori;
            return View(k);
        }
        [HttpPost]
        public IActionResult MakaleEkle(string Baslik, string Icerik, int MakaleDili, List<int> catid)
        {
            Makale m = new Makale();
            m.Baslik = Baslik;
            m.Icerik = Icerik;
            m.OlusturulanKullaniciId = Convert.ToInt32(HttpContext.Session.GetString("Id"));
            m.DurumTipi = false;
            m.ImageUrl = "~/images/portfolio/image4.jpg";

            switch (MakaleDili)
            {
                case 0:m.MakaleDili = "Turkce"; break;
                case 1:m.MakaleDili = "Ingilizce";break;
                case 2:m.MakaleDili = "Diger";break;
                default:m.MakaleDili = "Turkce";
                    break;
            }
            mb.Makale.Add(m);
            mb.SaveChanges();
            foreach (var cid in catid)
            {
                MakaleKategori mk = new MakaleKategori();
                mk.MakaleId = m.Id;
                mk.KategoriId = cid;
                mk.DurumTipi = true;
                mb.MakaleKategori.Add(mk);
                mb.SaveChanges();
            }
            IEnumerable<Kategori> k = mb.Kategori;

            return View(k);
        }
    }
}