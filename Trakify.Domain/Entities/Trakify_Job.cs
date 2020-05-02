using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_Job : BaseEntity
    {
        public Trakify_Client FkJobClient { get; set; }
        public string ContactPersonEmailSiteNameSite { get; set; }
        public string ContactPersonEmailSiteNoSite { get; set; }
        public string ContactPersonEmailSite { get; set; }
        public string WorkOrderNo { get; set; }
        public string OverrideWONo { get; set; }
        public string PurchaseOrderNo { get; set; }
        public Trakify_WorkOrderType FkWOType { get; set; }
        public Trakify_Code FKProductCode { get; set; }
        public string FailureCode { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int JobPriority { get; set; }
        public int BillingType { get; set; }
        public int Branch { get; set; }
        public int Department { get; set; }
        public int EmployeeRequiredSkills { get; set; }
        public int JobCheckListForm { get; set; }
        public int EmployeeRequiredOnsite { get; set; }
        public string CrewRequiredOnsite { get; set; }
        public bool IsGroupJob { get; set; }
        public bool AutoAssignToEmployee { get; set; }
        public bool RepeatJob { get; set; }
        public DateTime DateRequested { get; set; }
        public bool AssignToEarliestTimeSlot { get; set; }
        public string RequestedTimeWindow { get; set; }
        public string RequestedStartTime { get; set; }
        public string RequestedFinishTime { get; set; }
        public string PredifinedService { get; set; }
        public bool IsAnySpecialEquipment { get; set; }
        public bool IsAnySpecialAssets { get; set; }
        public string AttachDocument1 { get; set; }
        public string AttachDocument2 { get; set; }
        public string AttachDocument3 { get; set; }
        public Trakify_AddressDetails FkJobAddressDetails { get; set; }
    }
}
