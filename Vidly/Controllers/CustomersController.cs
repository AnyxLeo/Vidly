using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Anita la huerfanita"},
                new Customer {Id = 2, Name = "X-men"}
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }

        //GET: Customers/Details
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Anita la huerfanita"},
                new Customer {Id = 2, Name = "X-men"}
            };
            var customer = customers.Find(c => c.Id == id);

            if (customer!=null)
            {
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }
            
        }
    }
}