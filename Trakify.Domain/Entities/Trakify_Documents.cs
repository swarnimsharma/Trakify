using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_Documents :BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ModelNo { get; set; }
        public string File { get; set; }
    }
}
