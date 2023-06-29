using BuisnessAutomation.Database;
using BuisnessAutomation.Models.EntityModels;
using BuisnessAutomationApp.Models;
using BuisnessAutomationApp.Models.Customer;
using Microsoft.AspNetCore.Mvc;

namespace BuisnessAutomationApp.Controllers
{
    public class CustomerController : Controller
    {
        BusinessAutomationDbContext db;
        public CustomerController()
        {
            CustomerTable = new List<CustomerCreate>();
            db = new BusinessAutomationDbContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        //action er upor attibute ........
        [HttpGet]
        public IActionResult Create()
        {
            return View();
         }
        //action er upor attibute ........
        [HttpPost]
        public IActionResult Create(CustomerCreate customer)
        {
            /*//first time request
            if (customer.name != null && customer.Email != null)
            {
                //second /post request
                //database related code
                //customer save in database

            }*/
            //Modelstate amra controller theke pai
            /*if (ModelState.IsValid)
            {
                if (customer.phone.Length == 11)
                {
                    CustomerTable.Add(customer);
                }
                else
                {
                    ModelState.AddModelError("phone", "Phone Must be 11 digit!");
                }
                
            }*/
            if (customer.phone.Length != 11)
            {
                ModelState.AddModelError("phone", "Phone Must be 11 digit!");
            }
            if (ModelState.IsValid)
            {
                //data save operation
                //CustomerTable.Add(customer);
                var entity = new Customer()
                {
                    name = customer.name,
                    Email = customer.Email,
                    phone = customer.phone,
                };
                db.Customers.Add(entity);
                int successCount=db.SaveChanges();
                if (successCount > 0)
                {
                    ViewBag.SuccessMessage = "Saved Successfully!";
                    return View("Success");
                }
                
             }

                return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            var customerList = new List<CustomerCreate>() { 
                new CustomerCreate()
                {
                    name="A",
                    phone="16561516561",
                    Email="a@gmail.com"
                },
                new CustomerCreate()
                {
                    name="B",
                    phone="16561516561",
                    Email="b@gmail.com"
                },
                new CustomerCreate()
                {
                    name="C",
                    phone="16561516561",
                    Email="c@gmail.com"
                }
            };
            //ViewBag.CustomerList = customerList;
            //ViewData["CustomerList"]=customerList;
            var company = new Company()
            {
                CompanyId = "C001",
                Name = "Abc Company",
                Location = "Dhaka"
            };
            var customerListVM = new CustomerList()
            {
                Company = company,
                Customers = customerList,
            };
            
            return View(customerListVM);

        }
        public string CreateList(List<CustomerCreate> customers)
        {
            string message = "";
            foreach (var customer in customers)
            {
                message +=$"This is the create page for Customer:{customer.name} Phone:{customer.phone}\n";
            }
            return message;
        }
        //memory teh akbar jaiga dokhol jotokhon run thakbe toto khon jaiga dhore rakhbe static.....
        public static List<CustomerCreate> CustomerTable;
    }
}
