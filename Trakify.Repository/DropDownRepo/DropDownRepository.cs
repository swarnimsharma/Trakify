using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trakify.Domain;
using Trakify_Server.ViewModel;

namespace Trakify.Repository.DropDownRepo
{
    public class DropDownRepository : IDropDownRepository
    {
        private readonly TrakifyContext context;

        public DropDownRepository(TrakifyContext context)
        {
            this.context = context;
        }

        public List<DropDownViewModal> GetPartCategory()
        {
            var data = context.Trakify_PartCategory.Select(x => new DropDownViewModal
            {
                name = x.Category,
                value = x.Id
            }).ToList();
            return data;
        }

        public List<DropDownViewModal> GetPartVendors()
        {
            var data = context.Trakify_Vendors.Select(x => new DropDownViewModal
            {
                name = x.Name,
                value = x.Id
            }).ToList();
            return data;
        }
    }
}


