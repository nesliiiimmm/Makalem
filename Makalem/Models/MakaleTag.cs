using System;
using System.Collections.Generic;

namespace Makalem.Models
{
    public partial class MakaleTag
    {
        public int Id { get; set; }
        public int? MakaleId { get; set; }
        public int? TagId { get; set; }
        public bool? DurumTipi { get; set; }

        public Makale Makale { get; set; }
        public Tag MakaleNavigation { get; set; }
    }
}
