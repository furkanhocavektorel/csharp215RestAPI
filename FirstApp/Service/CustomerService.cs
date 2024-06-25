using FirstApp.Dtos.request;
using FirstApp.Dtos.response;
using Microsoft.AspNetCore.Mvc;
using Mvc.Models.Context;
using Mvc.Models.Entity;

namespace FirstApp.Service
{
    public class CustomerService : ICustomerService
    {
        NorthwindContext _context;

        public CustomerService(NorthwindContext context)
        {
            _context = context;
        }


        // 1. yöntem
        public List<ListCustomerResponseDto> customerList()
        {
            List<ListCustomerResponseDto> dtos= new List<ListCustomerResponseDto>();
            List<Customer> customers = _context.Customers.ToList();
            foreach (Customer customer in customers)
            {
                ListCustomerResponseDto dto = new ListCustomerResponseDto();

                dto.ContactName=customer.ContactName; // Furkan
                dto.City=customer.City; // İstanbul
                dto.Country=customer.Country; // Türkiye
                dto.PostaCode=customer.PostalCode;
                dtos.Add(dto);
            }

            return dtos;
        }


        // 2. yöntem
        public CustomerListeIcerenResponseDto customerList2()
        {
            CustomerListeIcerenResponseDto customerListeIcerenResponseDto = new CustomerListeIcerenResponseDto();

            List<ListCustomerResponseDto> dtoListesi = new List<ListCustomerResponseDto>();
            List<Customer> customers = _context.Customers.ToList();

            foreach (Customer customer in customers)
            {
                ListCustomerResponseDto dto = new ListCustomerResponseDto();

                dto.ContactName = customer.ContactName; // Furkan
                dto.City = customer.City; // İstanbul
                dto.Country = customer.Country; // Türkiye
                dto.PostaCode = customer.PostalCode;
                dtoListesi.Add(dto);
            }

            customerListeIcerenResponseDto.dtos= dtoListesi;

            customerListeIcerenResponseDto.KimGetirdiBuListeyi = "Furkan Türkmen";

            return customerListeIcerenResponseDto;
        }



        public GetCustomerByIdResponseDto getCustomerById(string id)
        {
            GetCustomerByIdResponseDto dto= new GetCustomerByIdResponseDto();

            Customer customer= _context.Customers.FirstOrDefault(c => c.CustomerID == id);

            dto.ContactName=customer.ContactName;
            dto.ContactTitle=customer.ContactTitle;
            dto.CompanyName=customer.CompanyName;
            dto.Phone=customer.Phone;  

            return dto;
        }

        public void CreateCustomer(CreateCustomerRequestDto request)
        {

            Customer customer = new Customer();

            customer.CustomerID = request.CustomerId;
            customer.CompanyName = request.CompanyName;
            customer.Phone = request.Phone;


            _context.Customers.Add(customer);
            _context.SaveChanges();

        }
    }
}
