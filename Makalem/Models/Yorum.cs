using System;
using System.Collections.Generic;

namespace Makalem.Models
{
    public partial class Yorum
    {
        public int Id { get; set; }
        public int? MakaleId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Yorum1 { get; set; }
        public bool? DurumTipi { get; set; }
        public int? OnaylanmayanKullanicId { get; set; }

        public Makale Makale { get; set; }
    }
}
