using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
    public class Trakify_Part : BaseEntity
    {
        public Trakify_PartCategory Category { get; set; }
        public int Quantity { get; set; }
        public bool Serialized { get; set; }
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Barcode { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
        public double Cost { get; set; }
        public double MinimumReorderLevel { get; set; }
        public double Markup { get; set; }
        public string Color { get; set; }
        public double SpiffAmount { get; set; }
        public string Photo { get; set; }
        public Trakify_Vendors Vendors { get; set; }
    }
}
