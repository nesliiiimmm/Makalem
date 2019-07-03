using System;
using System.Collections.Generic;

namespace Makalem.Models
{
    public partial class Kategori
    {
        public Kategori()
        {
            InverseUstKategori = new HashSet<Kategori>();
            MakaleKategori = new HashSet<MakaleKategori>();
        }

        public int Id { get; set; }
        public int? UstKategoriId { get; set; }
        public int? OlusturulanKullaniciId { get; set; }
        public string Adi { get; set; }
        public string ImageUrl { get; set; }
        public bool? DurumTipi { get; set; }

        public Kullanici OlusturulanKullanici { get; set; }
        public Kategori UstKategori { get; set; }
        public ICollection<Kategori> InverseUstKategori { get; set; }
        public ICollection<MakaleKategori> MakaleKategori { get; set; }
    }
}
