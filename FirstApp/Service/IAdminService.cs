using FirstApp.Dtos.response;
using FirstApp.Entity;

namespace FirstApp.Service
{
    public interface IAdminService
    {
        public List<AdminListResponse> listAdmin();


        public void SoftDeleteAdmin(int id);



        public void HardDeleteAdmin(int id);
    }
}
