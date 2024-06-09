using FirstApp.Service;
using Microsoft.AspNetCore.Mvc;
using Mvc.Models.Entity;

namespace FirstApp.Controllers
{
    [ApiController]
    [Route("api/v1/musteri")]
    public class CustomerController : ControllerBase
    {

        [HttpGet("liste")]
        public List<Customer> getCustomers()
        {
            CustomerService customerService = new CustomerService();

            List<Customer> list=customerService.customerList();

            return list; 
        }



        [HttpGet("idyegöremusterigetir")]
        public Customer GetCustomer(string id)
        {
            CustomerService customerService = new CustomerService();

           Customer customer= customerService.getCustomerById(id);

            return customer; // servisten bir musteri dönmeli
        }


    }
}
