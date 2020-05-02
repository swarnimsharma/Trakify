using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Service.PartService
{
  public  interface IPartService
    {
        IEnumerable<Trakify_Part> GetParts();
        Trakify_Part GetPart(int id);
        int InsertPart(Trakify_Part part);
        int InsertCategoryPart(Trakify_PartCategory part);
        int UpdatePart(Trakify_Part part);
        int DeletePart(Trakify_Part trakify_part);
        IEnumerable<Trakify_Vendors> GetPartVendorDetails();
    }
}
