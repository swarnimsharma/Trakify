using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Common;

namespace Trakify.Domain.Entities
{
   public class Trakify_Assets :BaseEntity
    {
        public string Name { get; set; }
        public bool IsSerializedAsset { get; set; }
        public string SerialNo { get; set; }
        public string AssetBarcode { get; set; }
        public DateTime? AssetAcquiredDate { get; set; }
        public int TotalInhandQuantity { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string Location { get; set; }
        public string SubArea { get; set; }
        public string SupplierName { get; set; }
        public double Cost { get; set; }
        public string AssetColour { get; set; }
        public string AssetPhoto { get; set; }
    }
}
