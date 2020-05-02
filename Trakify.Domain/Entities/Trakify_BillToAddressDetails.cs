using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_BillToAddressDetails :BaseEntity
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}
