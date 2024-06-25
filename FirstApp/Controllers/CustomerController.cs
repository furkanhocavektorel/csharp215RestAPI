using FirstApp.Dtos.request;
using FirstApp.Dtos.response;
using FirstApp.Service;
using Microsoft.AspNetCore.Mvc;
using Mvc.Models.Entity;

namespace FirstApp.Controllers
{
    [ApiController]
    [Route("api/v1/musteri")]
    public class CustomerController : ControllerBase
    {
        ICustomerService _icustomerService ;

        public CustomerController(ICustomerService icustomerService)
        {
            this._icustomerService = icustomerService;
        }

        // 1. yöntem
        [HttpGet("liste")]
        public List<ListCustomerResponseDto> getCustomers()
        {
            return _icustomerService.customerList();
        }



        // 2. yöntem
        [HttpGet("uzunliste")]
        public CustomerListeIcerenResponseDto getCustomersList()
        {
            return _icustomerService.customerList2();
        }



        [HttpGet("idyegöremusterigetir")]
        public GetCustomerByIdResponseDto GetCustomer(string id)
        {
            return _icustomerService.getCustomerById(id);
        }

        [HttpPost("ekle")]
        public void CreateCustomer([FromBody] CreateCustomerRequestDto request)
        {
            _icustomerService.CreateCustomer(request);
        }




    }
}
