using FirstApp.Dtos.request;
using FirstApp.Dtos.response;
using Microsoft.EntityFrameworkCore;
using Mvc.Models.Entity;

namespace FirstApp.Service
{
    public interface ICustomerService
    {

        // 1. yöntem
        public List<ListCustomerResponseDto> customerList();


        // 2. yöntem
        public CustomerListeIcerenResponseDto customerList2();


        public GetCustomerByIdResponseDto getCustomerById(string id);


        public void CreateCustomer(CreateCustomerRequestDto request);
      
    }
}
