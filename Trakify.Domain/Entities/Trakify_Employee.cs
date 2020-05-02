using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string StateCountryID { get; set; }
        public DateTime? DOB { get; set; }
        public string IssueingCountry { get; set; }
        public string Passport { get; set; }
        public string IdPhotoFront { get; set; }
        public string IdPhotoBack { get; set; }
        public int Branch { get; set; }
        public string Role { get; set; }
        public string Skills { get; set; }
        public int EmployeeType { get; set; }
        public double HourlyRate { get; set; }
        public double OverheadFactor { get; set; }
        public DateTime DOJ { get; set; }
        public int Department { get; set; }
        public int Position { get; set; }
        public string JobLocation { get; set; }
        public Trakify_User FkUser { get; set; }
    }
}
