using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookieKitchensGU.Models
{
    public class Staff : User
    {
        //Enumerator which contains all the staff role options
        enum StaffRole
        {
            Admin,
            SalesAssistant, 
            SalesManager,
            StockManager,
            InvoiceClerk,
            AssistantManager,
            WarehouseAssistant
        }

        //properties
        [Display(Name ="Staff Role")]
        private StaffRole staffRole { get; set; }
        private decimal Salary { get; set; }
        [Display(Name ="Date Hired")]
        private DateTime DateHired { get; set; }

        
    }
}