using System;
using System.Collections.Generic;
using System.Text;
using Trakify_Server.ViewModel;

namespace Trakify.Facade.DropDownFacade
{
   public  interface IDropDownFacade
    {
        List<DropDownViewModal> GetList(string type, int? id, string ids = null, string search = null);
    }
}
