using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_Client : BaseEntity
    {
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string FaxNumber { get; set; }
        public string AccountNumber { get; set; }
        public string AirMilesNo { get; set; }
        public string VatNo { get; set; }
        public double SalesDiscount { get; set; }
        public int InvoicePreference { get; set; }
        public string SpecialNote { get; set; }
        public int ClientType { get; set; }
        public string BusinessType { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonRole { get; set; }
        public string Website { get; set; }
        public string AccountManager { get; set; }
        public string SalesPerson { get; set; }

        public Trakify_User FkClientMasterUser { get; set; }

        public Trakify_User FkClientStaffUser { get; set; }

        public Trakify_AddressDetails FkClientAddressDetails { get; set; }

        public Trakify_BillToAddressDetails FkClientBillToAddressDetails { get; set; }

        public Trakify_TaxCode FkClientTaxCode { get; set; }

        public Trakify_PaymentTerms FkClientPaymentTerms { get; set; }

    }
}
