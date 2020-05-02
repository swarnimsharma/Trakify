using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Serilog;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using static System.Net.WebRequestMethods;

namespace Trakify_Server.Controllers
{
    public class HomeController : Controller
    {
		private readonly ILogger _logger;

		public HomeController(ILogger logger)
		{
			_logger = logger;
		}
		public IActionResult Index()
		{
			var ipAddress = "";
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					ipAddress = ip.ToString();
				}
			}
			//ControllerBase.HttpContext.Session session = new HttpContext.Session();
			HttpContext.Session.SetString("ClientIp", ipAddress);
			Log.Information("Index");
			_logger.Information("[" + ipAddress + "] Home page accessed.");
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult FileUpload()
		{
			return View();
		}
	}
}