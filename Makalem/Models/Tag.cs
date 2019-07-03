using System;
using System.Collections.Generic;

namespace Makalem.Models
{
    public partial class Tag
    {
        public Tag()
        {
            MakaleTag = new HashSet<MakaleTag>();
        }

        public int Id { get; set; }
        public int? OlusturlanKullaniciId { get; set; }
        public string Adi { get; set; }
        public bool? DurumTipi { get; set; }

        public Kullanici OlusturlanKullanici { get; set; }
        public ICollection<MakaleTag> MakaleTag { get; set; }
    }
}
