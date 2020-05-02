using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trakify.Domain.Entities;
using Trakify.Facade.PartFacade;

namespace Trakify_Server.Controllers
{
    public class PartsController : Controller
    {
        private readonly IpartFacade _partFacade;

        public PartsController(IpartFacade _partFacade)
        {
            this._partFacade = _partFacade;
           
        }
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _Parts()
        {
            var a = _partFacade.GetParts();
            return PartialView(a);
        }
        
        [HttpPost]
        public JsonResult SaveParts(Trakify_Part trakify_Parts)
        {
            return Json(_partFacade.InsertPart(trakify_Parts));
        }
        [HttpPost]
        public JsonResult SaveCategoryParts(Trakify_PartCategory trakify_PartCategory)
        {
            return Json(_partFacade.InsertCategoryPart(trakify_PartCategory));
        }

        [HttpPost]
        public JsonResult UpdateParts(Trakify_Part trakify_Asset)
        {
            return Json(_partFacade.UpdatePart(trakify_Asset));
        }

        public JsonResult GetPartsData(Trakify_Part trakify_Asset)
        {
            return Json(_partFacade.UpdatePart(trakify_Asset));
        }

         public JsonResult GetPartVendorDetails()
        {
            var a = _partFacade.GetPartVendorDetails();
            return Json(a);
        }
        //public ActionResult PartCategory(int Id)
        //{
        //    ViewBag.PartId = Id;
        //    return View();
        //}
        //[HttpPost]
        //public PartialViewResult _PartCategory(int id)
        //{
        //    return PartialView(_partFacade.GetPart(id));
        //}

    }

}
