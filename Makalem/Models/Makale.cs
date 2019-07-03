using System;
using System.Collections.Generic;

namespace Makalem.Models
{
    public partial class Makale
    {
        public Makale()
        {
            MakaleKategori = new HashSet<MakaleKategori>();
            MakaleTag = new HashSet<MakaleTag>();
            Yorum = new HashSet<Yorum>();
        }

        public int Id { get; set; }
        public int? OlusturulanKullaniciId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string ImageUrl { get; set; }
        public bool? DurumTipi { get; set; }
        public string MakaleDili { get; set; }

        public Kullanici OlusturulanKullanici { get; set; }
        public ICollection<MakaleKategori> MakaleKategori { get; set; }
        public ICollection<MakaleTag> MakaleTag { get; set; }
        public ICollection<Yorum> Yorum { get; set; }
    }
}
