using System.Web.Http;
using T4_WebApi.Models;

namespace T4_WebApi.Controllers
{
    public class PaymentController : ApiController
    {
        [HttpPost]
        [Route("api/Payment/Callback")]
        public IHttpActionResult Callback([FromBody] CallbackResponse callback)
        {
            string logData = $"[PAYMENT STATUS CALLBACK(PAYMENT/CALLBACK)][{callback.status}] " +
                $"MERCHANT ID:{callback.CID}---REF. NO.(Gkash):{callback.POID}" +
                $"---REF. ID(MERCHANT):{callback.cartid}---SIGNATURE:{callback.signature}";
            Logger.LogInfo(logData);
            return Ok();
        }
    }
}
