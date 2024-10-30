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

            var list = context.Admins.ToList();

            var listResponse = new List<AdminListResponse>();

            foreach (var admin in list)
            {
                AdminListResponse adminListResponse = new AdminListResponse();
                adminListResponse.Id = admin.Id;
                adminListResponse.Name = admin.Name;
                adminListResponse.Deleted = admin.Deleted;

                listResponse.Add(adminListResponse);

            }
            listResponse.Add(new AdminListResponse());
             




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
