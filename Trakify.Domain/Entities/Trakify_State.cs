using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_State
    {
        [Key]
        public int Id { get; set; }
        public string StateName { get; set; }
    }
}
