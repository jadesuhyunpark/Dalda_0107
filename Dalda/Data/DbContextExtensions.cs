using Dalda.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Dalda.Data
{
    public static class DbContextExtensions
    {
        public static UserManager<AppUser> UserManager{ get; set; }
        public static void EnsureSeeded(this DaldaContext context)
        {
            if (UserManager.FindByEmailAsync("kdk_kang_c@naver.com").GetAwaiter().GetResult() == null)
            {
                var user = new AppUser
                {
                FirstName = "dong kyun",
                LastName = "kang",
                UserName = "kdk_kang_c@naver.com",
                Email = "kdk_kang_c@naver.com",
                EmailConfirmed = true,
                LockoutEnabled = false
                };
                UserManager.CreateAsync(user, "Password1*").GetAwaiter().GetResult();
            }
        }

    }
}