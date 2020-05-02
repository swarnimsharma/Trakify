using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
    public class Trakify_Vendors : BaseEntity
    {
        public IEnumerable<Trakify_Part> Parts { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public double Price { get; set; }
    }
}
