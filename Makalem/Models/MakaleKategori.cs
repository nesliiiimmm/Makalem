using System;
using System.Collections.Generic;

namespace Makalem.Models
{
    public partial class MakaleKategori
    {
        public int Id { get; set; }
        public int? MakaleId { get; set; }
        public int? KategoriId { get; set; }
        public bool? DurumTipi { get; set; }

        public Kategori Kategori { get; set; }
        public Makale Makale { get; set; }
    }
}
