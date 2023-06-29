using Microsoft.AspNetCore.Mvc;

namespace BuisnessAutomationApp.Models.Customer
{
    public class CustomerList 
    {
        public List<CustomerCreate> Customers { get; set; }
        public Company Company { get; set; }
        /* public IActionResult Index()
         {
             return View();
         }*/
    }
}
