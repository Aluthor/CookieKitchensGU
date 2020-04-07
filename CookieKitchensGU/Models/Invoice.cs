using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CookieKitchensGU.Models
{
    public class Invoice
    {
        //Properties
        [Required]
        [Display(Name = "Invoice Id")]
        public int InvoiceId { get; set; }

        public decimal Cost { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool IsPaid { get; set; }
        public DateTime ExpiryDate { get; set; }

        //Navigational Properties
        [ForeignKey("Trade Customer")]
        public int CustomerId { get; set; }
        public TradeCust TradeCust{ get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}