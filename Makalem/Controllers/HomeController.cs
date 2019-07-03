
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Makalem.Models;
using Microsoft.Extensions.Configuration;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static System.Collections.Specialized.BitVector32;
using Microsoft.AspNetCore.Authorization;


namespace Makalem.Controllers
{
   
    public class HomeController : Controller
    {
        MakaleAraBulContext mabc = new MakaleAraBulContext();
      
        public IActionResult Index()
        {
            IEnumerable<Kategori> kategori = mabc.Kategori;
            IEnumerable<Makale> makale = mabc.Makale;
            IEnumerable<MakaleKategori> mk = mabc.MakaleKategori;
            return View(Tuple.Create(kategori,makale,mk));
        }
        [HttpPost]
        public IActionResult Index(String searchstring)
        {
            IEnumerable<Makale> makale = mabc.Makale;
            IEnumerable<Kategori> kategori = mabc.Kategori;
            if (!String.IsNullOrEmpty(searchstring)) {
               
                IEnumerable<Makale> mak = mabc.Makale.Where(i => i.Baslik.Contains(searchstring));
                if (mak.Any() == true)
                {
                    return View(Tuple.Create(kategori, mak));                
                }
                else
                    ViewData["search"] = "Oops! Aradığınız makale bulunamadı !";
                    return View(Tuple.Create(kategori, mak));
                

            }
            return View(Tuple.Create(kategori, makale));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        
        public IActionResult ViewArticle(int id) {
            //ViewData["Id"] = "MakaleId";
            Makale makale= mabc.Makale.FirstOrDefault(i => i.Id == id);
           IEnumerable<Yorum> yorum = mabc.Yorum.Where(i => i.MakaleId == id);
            return View(Tuple.Create(yorum, makale));
        }
        [HttpPost]
        public IActionResult ViewArticle(string dname,string dsurname,string demail, string comment,int id)
        {
            Yorum yrm = new Yorum();
            yrm.Adi = dname;
            yrm.Soyadi = dsurname;
            yrm.Email = demail;
            yrm.Yorum1 = comment;
            yrm.MakaleId = id;
            yrm.DurumTipi = false; //deneme amaçlı true yoksa false olmalı. Onaylandıktan sonra true olcak.
            mabc.Yorum.Add(yrm);
            mabc.SaveChanges();
            Makale makale = mabc.Makale.FirstOrDefault(i => i.Id == id);
            IEnumerable<Yorum> yorum = mabc.Yorum.Where(i => i.MakaleId == id);
            return View(Tuple.Create(yorum, makale));
        }


    }
}
