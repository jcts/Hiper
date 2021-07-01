using Hiper.Application.Contracts;
using Hiper.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiper.WebApp.Controllers
{
    public class CustomerController : Controller
    {
        readonly ICustomerApp _customerApp;

        public CustomerController(ICustomerApp customerApp)
        {
            _customerApp = customerApp;
        }

        public IActionResult Index()
        {
            var customers = _customerApp.GetAll();

            return View(customers);
        }

        public IActionResult Create()
            => View();

        [HttpPost, AutoValidateAntiforgeryToken]
        public IActionResult Create(CustomerModel customer)
        {
            try
            {
                _customerApp.Create(customer);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
