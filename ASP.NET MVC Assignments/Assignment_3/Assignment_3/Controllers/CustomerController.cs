using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Customer_Management_System;

namespace Assignment_3.Controllers
{
    public class CustomerController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Customer c)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    CustomerDB cdb= new CustomerDB();
                    if(cdb.Addcustomer(c))
                    {
                        ViewBag.Message = "Customer Details Added Successfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "Customer Details Added Successfully";
                    }
                }
                return View();
            }
            catch
            {
                ViewBag.Message = "Customer Details Are Not Valid";
                return View();
            }
        }
        public ActionResult CustomerSummary()
        {
            CustomerDB cdb = new CustomerDB();
            ModelState.Clear();
            return View(cdb.GetCustomers());
        }
        
        public ActionResult Modify(int id)
        {
            CustomerDB cdb = new CustomerDB();
            return View(cdb.GetCustomers().Find(c=>c.CustomerId==id));
        }
        [HttpPost]
        public ActionResult Modify(int id,Customer c)
        {
            try
            {
                CustomerDB cdb = new CustomerDB();
                cdb.Modifycustomer(c);
                return RedirectToAction("CustomerSummary");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Remove(int id)
        {
            try
            {
                CustomerDB cdb = new CustomerDB();
                if (cdb.Removecustomer(id))
                {
                    ViewBag.AlertMsg = "Customer Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Search(string Searchby, string search)
        {
            try
            {
                CustomerDB cdb = new CustomerDB();
                if (Searchby == "CustomerName")
                {
                   
                    List<Customer> model = cdb.GetCustomers().Where(c => c.CustomerName.StartsWith(search) || search == null).ToList();
                    ModelState.Clear();
                    return View(model);
                }
                else
                {
                    
                    List<Customer> model = cdb.GetCustomers().Where(c => c.CustomerId == Convert.ToInt32(search) || search == null).ToList();

                    ModelState.Clear(); 
                    return View(model);
                }
            }
            catch
            {
                return View(search);
            }

        }



    }
}