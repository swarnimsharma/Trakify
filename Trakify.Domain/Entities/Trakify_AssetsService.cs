using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
    public class Trakify_AssetsService:BaseEntity
    {
        public string Title { get; set; }
        public Trakify_Assets Trakify_AssetsServices { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public DateTime? ServicedDate { get; set; }

    }
}
