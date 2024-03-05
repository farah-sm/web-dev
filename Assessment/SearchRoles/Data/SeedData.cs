using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SearchRoles.Models;
using System;
using System.Threading.Tasks;

namespace SearchRoles.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            var roles = new[] {"Admin", "Manager", "Member"};

            foreach (var role in roles)
            {
                    // Check if the Admin role already exists
                if (!await roleManager.RoleExistsAsync(role))
                {
                    // If the roles don't exist, create them
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }


            // Admin User creation
            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();

            string email = "test-admin@email.com";
            string password = "SaedFarah19!";

            if(await userManager.FindByEmailAsync(email) == null)
            {
                var user = new IdentityUser();
                user.UserName = email;
                user.Email = email;

                await userManager.CreateAsync(user, password);

                await userManager.AddToRoleAsync(user, "Admin");
            }

           
        }
    }
}
