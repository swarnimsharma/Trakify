using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_TaxCode : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Agency { get; set; }
        public double TaxRate { get; set; }
   }
}
