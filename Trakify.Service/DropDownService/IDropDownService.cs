using System;
using System.Collections.Generic;
using System.Text;
using Trakify_Server.ViewModel;

namespace Trakify.Service.DropDownService
{
    public interface IDropDownService
    {
        List<DropDownViewModal> GetList(string type, int? id, string ids = null, string search = null);
    }
}
