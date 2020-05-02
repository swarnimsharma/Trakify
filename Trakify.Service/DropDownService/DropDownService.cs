using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Repository.DropDownRepo;
using Trakify_Server.ViewModel;

namespace Trakify.Service.DropDownService
{
    public class DropDownService : IDropDownService
    {
        private readonly IDropDownRepository dropDown;
        public DropDownService(IDropDownRepository dropDown)
        {
            this.dropDown = dropDown;
        }
        public List<DropDownViewModal> GetList(string type, int? id, string ids = null, string search = null)
        {
            if (type == "PartCategory")
            {
                return dropDown.GetPartCategory();
            }
            if (type == "PartVendor")
            {
                return dropDown.GetPartVendors();
            }
            else
                return null;
        }
    }
}
