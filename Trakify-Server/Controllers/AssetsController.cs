using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Trakify.Domain;
using Trakify.Domain.Entities;
using Trakify.Facade.AssetsFacade;

namespace Trakify_Server.Controllers
{
    public class AssetsController : Controller
    {

        private readonly IAssetsFacade _assetsFacade;
        private readonly ILogger _logger;

        public AssetsController(IAssetsFacade assetsFacade, ILogger logger)
        {
            this._assetsFacade = assetsFacade;
            _logger = logger;
        }
        // GET: Trakify_Assets
        public ActionResult Index()
        {
            var ipAddress = HttpContext.Session.GetString("ClientIp");
            Log.Information("Index");
            _logger.Information("[" + ipAddress + "] Assets page accessed.");
            return View();
        }
        public PartialViewResult _Assets()
        {
            var a = _assetsFacade.GetAssets();
            return PartialView(a);
        }
        public ActionResult AssetsMaintaneance()
        {
            return View();
        }

        public PartialViewResult _AssetMaintaneance()
        {
            return PartialView(_assetsFacade.GetAssets());
        }
        public JsonResult DetailsAsset(int id)
        {
            return Json(_assetsFacade.GetAsset(id));
        }
        public ActionResult DetailsAssetsServiceList(int Id)
        {
            ViewBag.AssetId = Id;
            return View();
        }

        public PartialViewResult _DetailsAssetsServiceList(int id)
        {
            return PartialView(_assetsFacade.GetAsset(id));  
        }

        public PartialViewResult _AssetsServiceList(int id)
        {
            var a = _assetsFacade.GetAssetServices(id);
            return PartialView(a);
        }

        [HttpPost]
        public JsonResult SaveAssets(Trakify_Assets trakify_Assets)
        {
            return Json(_assetsFacade.InsertAsset(trakify_Assets));
        }
        [HttpPost]
        public JsonResult SaveAssetService(Trakify_AssetsService trakify_Service)
        {
            return Json(_assetsFacade.InsertAssetService(trakify_Service));
        }

        [HttpPost]
        public JsonResult UpdateAsset(Trakify_Assets trakify_Assets)
        {
            return Json(_assetsFacade.UpdateAsset(trakify_Assets));
        }

        public JsonResult GetAssetsData(long id)
        {
            return Json(_assetsFacade.GetAsset(id));

        }

        [HttpPost]
        public JsonResult DeleteAsset(Trakify_Assets trakify_Assets)
        {
            return Json(_assetsFacade.DeleteAsset(trakify_Assets));     
        }

    }
}
