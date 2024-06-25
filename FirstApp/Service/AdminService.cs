using FirstApp.Dtos.response;
using FirstApp.Entity;
using Mvc.Models.Context;

namespace FirstApp.Service
{
    public class AdminService : IAdminService
    {
        NorthwindContext context;

        public AdminService(NorthwindContext context)
        {
            this.context = context; 
        }

        public List<AdminListResponse> listAdmin()
        {

            List<Admin> list = context.Admins.ToList();

            List<AdminListResponse> listResponse = new List<AdminListResponse>();

            foreach (Admin admin in list)
            {
                AdminListResponse adminListResponse = new AdminListResponse();
                adminListResponse.Id = admin.Id;
                adminListResponse.Name = admin.Name;
                adminListResponse.Deleted = admin.Deleted;

                listResponse.Add(adminListResponse);

            }

            return listResponse;
        }



        public void SoftDeleteAdmin(int id)
        {
            var admin = context.Admins.SingleOrDefault(a=> a.Id==id);

            if (admin != null)
            {
                admin.Deleted = true;
                context.SaveChanges();
            }

        }

        public void HardDeleteAdmin(int id)
        {
            var admin = context.Admins.SingleOrDefault(a => a.Id == id);
          
            if (admin != null)
            {
                context.Admins.Remove(admin);
                context.SaveChanges();
                
            }


        }








    }
}
