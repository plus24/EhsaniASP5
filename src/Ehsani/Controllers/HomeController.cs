using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Ehsani.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public IActionResult Media()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        public JsonResult SendMsg(string name, string email,string phone, string message)
        {
            //ir.payamtube.smsSendWebService SMS = new ir.payamtube.smsSendWebService();

            //// Enable Session Status
            //SMS.CookieContainer = new System.Net.CookieContainer();
            //// Login
            //SMS.Login("ehsani", "232425", "payamtube");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            //// Send SMS
            //long SmsId = SMS.SendSingleSms(name + System.Environment.NewLine + email + System.Environment.NewLine + msg, "09138080160", "20003020", ir.payamtube.SmsMode.SaveInPhone);
            ////Get Credit
            //string Credit = SMS.getCredit();
            return Json(new { res = "OK" });
        }
    }
}
