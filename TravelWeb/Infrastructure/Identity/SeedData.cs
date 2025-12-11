using Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace TravelWeb.Infrastructure.Identity
{
    public static class SeedData
    {
        public static async Task AdminUser(IServiceProvider serviceProvider)
        {
/*             var roleManager = serviceProvider.GetRequiredService<RoleManager<Role>>(); 
 */            var userManager = serviceProvider.GetRequiredService<UserManager<Writer>>();

            var adminEmail ="ceyhun@travel.az";
            var adminUser =await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser =new Writer
                {
                     UserName="Admin",
                     Email =adminEmail,
                     EmailConfirmed =true
                };

                await userManager.CreateAsync(adminUser,"adminUser12345+");
            }
        }
    }
}