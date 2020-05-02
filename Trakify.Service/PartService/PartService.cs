using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Domain.Entities;
using Trakify.Repository;
using Trakify.Repository.Common;

namespace Trakify.Service.PartService
{
   public class PartService : IPartService
    {
        private readonly IRepository<Trakify_Part> partRepository;
        private readonly IRepository<Trakify_PartCategory> partCategoryRepository;
        private readonly IRepository<Trakify_Vendors> partVendorRepository;
        public PartService(IRepository<Trakify_Part> partRepository, IRepository<Trakify_Vendors> partVendorRepository, IRepository<Trakify_PartCategory> partCategoryRepository)
        {
            this.partRepository = partRepository;
            this.partVendorRepository = partVendorRepository;
            this.partCategoryRepository = partCategoryRepository;
        }

        public int DeletePart(Trakify_Part trakify_Part)
        {
            return partRepository.Delete(trakify_Part);
        }
       
        public Trakify_Part GetPart(int id)
        {
            return partRepository.Get(id);
        }

        public IEnumerable<Trakify_Part> GetParts()
        {
            return partRepository.GetAll();
        }
        public IEnumerable<Trakify_Vendors> GetPartVendorDetails()
        {
            return partVendorRepository.GetAll();
        }

        public int InsertCategoryPart(Trakify_PartCategory part)
        {
            return partCategoryRepository.Insert(part);
        }

        public int InsertPart(Trakify_Part part)
        {
           return partRepository.Insert(part);
        }

        public int UpdatePart(Trakify_Part part)
        {
          return  partRepository.Update(part);
        }

      
    }
}
