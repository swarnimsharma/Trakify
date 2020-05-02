using System;
using System.Collections.Generic;
using System.Text;
using Trakify.Service.DropDownService;
using Trakify_Server.ViewModel;

namespace Trakify.Facade.DropDownFacade
{
    public class DropDownFacade : IDropDownFacade
    {
        private readonly IDropDownService dropDown;
        public DropDownFacade(IDropDownService dropDown)
        {
            this.dropDown = dropDown;
        }
        public List<DropDownViewModal> GetList(string type, int? id, string ids = null, string search = null)
        {
            return dropDown.GetList(type, id, ids, search);
        }
    }
}
