using FirstApp.Dtos.response;
using FirstApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    [ApiController]
    [Route("api/v1/admin")]
    public class AdminController : ControllerBase
    {
        IAdminService _adminservice;

        public AdminController(IAdminService service)
        {
            _adminservice = service;
        }

        [HttpGet]
        public List<AdminListResponse> adminListResponses()
        {
            return _adminservice.listAdmin();
        }

        [HttpDelete]
        public void SoftDelete(int id)
        {
            _adminservice.SoftDeleteAdmin(id);
        }

        [HttpPut]
        public void HardDelete(int id)
        {
            _adminservice.HardDeleteAdmin(id);
        }



    }
}
