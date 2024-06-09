using Microsoft.AspNetCore.Mvc;
using Mvc.Models.Context;
using Mvc.Models.Entity;

namespace FirstApp.Service
{
    public class CustomerService
    {


    


        public List<Customer> customerList()
        {
            NorthwindContext context = new NorthwindContext();
            List<Customer> customers = context.Customers.ToList();
            return customers;
        }

        public Customer getCustomerById(string id)
        {
            NorthwindContext context = new NorthwindContext();
            Customer customer=context.Customers.FirstOrDefault(c => c.CustomerID == id);
            return customer;
        }
    }
}
