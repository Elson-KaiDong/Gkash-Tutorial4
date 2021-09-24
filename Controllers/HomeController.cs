using System.Web.Mvc;
using T4_WebApi.Models;

namespace T4_WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        [System.Web.Http.HttpPost]
        public ActionResult Return(ReturnResponse response)
        {
            string logData = $"[PAYMENT RESPONSE(HOME/RETURN)][{response.status}]" +
                $"---MERCHANT ID:{response.CID}---REF. NO.(Gkash):{response.POID}" +
                $"---REF. ID(MERCHANT):{response.cartid}---SIGNATURE:{response.signature}";
            Logger.LogInfo(logData);
            return View(response);
        }
    }
}
