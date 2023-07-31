using Ajax_Project.DAL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ajax_Project.Controllers
{
    public class DefaultController : Controller
    {
        Context context=new Context();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CustomerList()
        {
            var jsonCustomer = JsonConvert.SerializeObject(context.Customers.ToList());
            return Json(jsonCustomer);
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            var values = JsonConvert.SerializeObject(customer);
            context.SaveChanges();
            return Json(values);
        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Find(id);
            context.Customers.Remove(value);
            context.SaveChanges();
            return NoContent();
        }
        public IActionResult GetCustomer(int CustomerID)
        {
            var value = context.Customers.Find(CustomerID);
            var jsonCustomer = JsonConvert.SerializeObject(value);
            return Json(jsonCustomer);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
            return NoContent();
        }
    }
}
