using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Hiburan.Data
{
    public static class SeedRoles
    {
        public static void Initialize(IServiceProvider provider)
        {
            using (var scope = provider.CreateScope())
            {
                var roleManager = (RoleManager<IdentityRole>)scope.ServiceProvider.GetService(typeof(RoleManager<IdentityRole>));

                CheckRole(roleManager, "Admin");
            }


        }

        private static void CheckRole(RoleManager<IdentityRole> roleManager, string rolename)
        {
            if (!roleManager.RoleExistsAsync(rolename).GetAwaiter().GetResult())
            {
                roleManager.CreateAsync(new IdentityRole(rolename)).GetAwaiter().GetResult();
            }
        }
    }
}
