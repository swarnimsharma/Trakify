using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
    public class Trakify_Projects : BaseEntity
    {
        public Trakify_Client Trakify_Client { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescriptipon { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Value { get; set; }
        public DateTime PaymentSchedule { get; set; }
    }
}
