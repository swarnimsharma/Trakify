using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Trakify.Facade.DropDownFacade;
using Trakify_Server.ViewModel;

namespace Trakify_Server.Controllers
{
    public class DropDownController : Controller
    {

        private readonly IDropDownFacade dropDown;
        public DropDownController(IDropDownFacade dropDown)
        {
            this.dropDown = dropDown;
        }

        [HttpGet]
        public JsonResult GetDropdown(string type, int? id = null, string ids = null, string search = null)
        {
            List<DropDownViewModal> dropDownList = new List<DropDownViewModal>();
            dropDownList = dropDown.GetList(type, id, ids, search);
            var data= Json(dropDownList);
            return data;
        }
    }
}