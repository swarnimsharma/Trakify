using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Facade.PartFacade
{
    public interface IpartFacade
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
