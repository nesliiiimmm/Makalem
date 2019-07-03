using System;
using System.Collections.Generic;

namespace Makalem.Models
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            Kategori = new HashSet<Kategori>();
            Makale = new HashSet<Makale>();
            Tag = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public byte? KullaniciTipi { get; set; }
        public bool? DurumTipi { get; set; }

        public ICollection<Kategori> Kategori { get; set; }
        public ICollection<Makale> Makale { get; set; }
        public ICollection<Tag> Tag { get; set; }
    }
}
