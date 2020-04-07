using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookieKitchensGU.Models
{
    public class Product
    {
        //Properties
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public string ProductColour { get; set; }
        public int StockQuantity { get; set; }
        public int ReOrderQuantity { get; set; }
        public DateTime DeliveryTime { get; set; }

        //Navigational Properties
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}