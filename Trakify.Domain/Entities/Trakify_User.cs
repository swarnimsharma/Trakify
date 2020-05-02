using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
  public  class Trakify_User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        
    }
}
