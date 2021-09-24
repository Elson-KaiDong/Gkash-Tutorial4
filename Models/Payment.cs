using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace T4_WebApi.Models
{
    public class Payment
    {
        [Required]
        public string version= "1.5.5";

        [Required]
        [DisplayName("Merchant ID")]
        public string CID { get; set; }

        [Required]
        [DisplayName("Cart ID")]
        public string v_cartid{ get; set; }

        [Required]
        [DisplayName("Currency")]
        public string v_currency { get; set; }

        [Required]
        [DisplayName("Amount")]
        public string v_amount { get; set; }

        [Required]
        public string signature { get; set; }
        public string returnurl { get; set; } 
        public string callbackurl { get; set; }
        public string v_firstname { get; set; }
        public string v_lastname { get; set; }
        public string v_billemail { get; set; }
        public string v_billstate { get; set; }
        public string v_bill_country { get; set; }
        public string v_billphone { get; set; }
        public string v_shipstreet { get; set; }
        public string v_shippost { get; set; }
        public string v_shipcity { get; set; }
        public string v_shipstate { get; set; }
        public string v_ship_country { get; set; }
        public string clinetip { get; set; }
        public string v_productdesc { get; set; }
        public string preselection { get; set; }
        public string recurringtype { get; set; }
        public string v_preauth { get; set; }
    }
}