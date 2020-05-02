using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public  class Trakify_BasicSettings :BaseEntity
    {
        public Trakify_TImeZone FkBaseSettingTimeZone { get; set; }
        public  Trakify_DateFormat  FkBaseSettingDateFormat { get; set; }
        public Trakify_Currency FkBaseSettingCurrency { get; set; }
        public int NetDueDays { get; set; }
        public int FinancialMonth { get; set; }
        public string IRDTAX { get; set; }
        public bool IsDashboardMap { get; set; }
        public string OfficeStartTiming { get; set; }
        public string OfficeEndTiming { get; set; }
        public bool  IsPrintInvoiceDetails { get; set; }
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public string BankSortCode { get; set; }
        public string BankAddress { get; set; }
        public bool AllowInvoicing { get; set; }
        public bool EmployeeAssignJob { get; set; }
        public bool EmployeeeRscheduleJob { get; set; }
        public bool AllowToAccessInvoice { get; set; }
        public bool AllowToAccessClients { get; set; }
        public bool AllowToAccessContracts { get; set; }
        public string InvoiceTermCondition { get; set; }
        public string EstimateTermCondition { get; set; }
        public string WOTermCondition { get; set; }
        public string ServiceContractTermCondition { get; set; }

    }
}
