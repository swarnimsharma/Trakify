using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Service.PartService;

namespace Trakify.Facade.PartFacade
{
    public class PartFacade : IpartFacade
    {
        private readonly IPartService partService;
      
        public PartFacade(IPartService partService)
        {
            this.partService = partService;
        }
        public int DeletePart(Trakify_Part trakify_part)
        {
            return partService.DeletePart(trakify_part);
        }
        public Trakify_Part GetPart(int id)
        {
            return partService.GetPart(id);
        }

        public IEnumerable<Trakify_Part> GetParts()
        {
            return partService.GetParts();
        }
        public int InsertPart(Trakify_Part part)
        {
            return partService.InsertPart(part);
        }
        public int UpdatePart(Trakify_Part part)
        {
            return partService.UpdatePart(part);
        }
        public IEnumerable<Trakify_Vendors> GetPartVendorDetails()
        {
            return partService.GetPartVendorDetails();
        }

        public int InsertCategoryPart(Trakify_PartCategory part)
        {
            return partService.InsertCategoryPart(part);
        }
    }
}
