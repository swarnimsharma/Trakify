using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public  class Trakify_PartVendors: BaseEntity
    {
        
        public int Cost { get; set; }
        public int Number { get; set; }
        public Trakify_Vendors fk_vendor_id { get; set; }
        public Trakify_Part fk_part_id { get; set; }

    }
}
