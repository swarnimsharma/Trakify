using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_Code :BaseEntity
    {
        public string Name { get; set; }
        public int CodeType { get; set; }
        public string Description { get; set; }
    }
}
