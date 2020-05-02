using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_Contracts : BaseEntity
    {
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string ContactSubTypeCode { get; set; }
        public double Price { get; set; }
        public int BillingSchedule { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IncludeNoService { get; set; }
        public string PurchaseOrder { get; set; }
        public string ServicesDescription { get; set; }
        public string PrivateNotes { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonPhone { get; set; }
        public string ContactPersonMobile { get; set; }
        public string ContactPersonEmail { get; set; }
        public int FkContractType { get; set; }

        [ForeignKey("FkContractType")]
        public Trakify_ContractType AddressCountry { get; set; }
    }
}
