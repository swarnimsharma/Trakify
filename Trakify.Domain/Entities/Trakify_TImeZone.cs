using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Trakify.Domain.Entities
{
   public class Trakify_TImeZone
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
