using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_AddressDetails: BaseEntity
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }

        public string ZipCode { get; set; }
       
        public Trakify_Country FkCountry { get; set; }

        public Trakify_State FkState { get; set; }


    }
}
