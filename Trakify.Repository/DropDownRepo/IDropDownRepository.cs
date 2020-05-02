using System;
using System.Collections.Generic;
using System.Text;
using Trakify_Server.ViewModel;

namespace Trakify.Repository.DropDownRepo
{
   public interface IDropDownRepository
    {
        List<DropDownViewModal> GetPartCategory();
        List<DropDownViewModal> GetPartVendors();
    }
}
