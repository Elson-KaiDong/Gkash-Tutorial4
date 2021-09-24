using System.ComponentModel;

namespace T4_WebApi.Models
{
    public class CallbackResponse
    {
        [DisplayName("Status")]
        public string status { get; set; }

        [DisplayName("Merchant ID")]
        public string CID { get; set; }

        [DisplayName("Gkash Reference No.")]
        public string POID { get; set; }

        [DisplayName("Merchant Reference No.")]
        public string cartid { get; set; }

        [DisplayName("Currency")]
        public string currency { get; set; }

        [DisplayName("Amount")]
        public string amount { get; set; }

        [DisplayName("Payment Method")]
        public string PaymentType { get; set; }
        public string signature { get; set; }
        public string epkey { get; set; }
    }
}