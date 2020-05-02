using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
  public  class Trakify_ContactDetails :BaseEntity
    {
        public string Mobile { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public int FkEmployeeID { get; set; }
    }
}
