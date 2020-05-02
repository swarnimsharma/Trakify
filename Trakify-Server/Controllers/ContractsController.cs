using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trakify.Domain;
using Trakify.Domain.Entities;
using Trakify.Facade.ContractsFacade;
namespace Trakify_Server.Controllers
{
    public class ContractsController : Controller
    {
       
        private readonly IContractFacade _contractFacade;
        public ContractsController(IContractFacade _contractFacade)
        {
          
            this._contractFacade = _contractFacade;
        }
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _Contracts()
        {
            return PartialView(_contractFacade.GetContract());
        }
        public JsonResult DetailsContract(int id)
        {
            return Json(_contractFacade.GetContract(id));
        }
        [HttpPost]
        public JsonResult SaveContract(Trakify_Contracts trakify_Assets)
        {
            return Json(_contractFacade.InsertContract(trakify_Assets));
        }

        [HttpPost]
        public JsonResult UpdateContract(Trakify_Contracts trakify_Assets)
        {
            return Json(_contractFacade.UpdateContract(trakify_Assets));
        }
        public JsonResult GetContractData(int id)
        {
            return Json(_contractFacade.GetContract(id));
        }

        [HttpPost]
        public JsonResult DeleteContract(int id)
        {
            return Json(_contractFacade.DeleteContract(id));
        }

        public JsonResult GetContractType()
        {
            var a = _contractFacade.GetContractType();
            return Json(a);
        }

    }
}