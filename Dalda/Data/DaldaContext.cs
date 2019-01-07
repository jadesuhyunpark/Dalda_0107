using Dalda.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dalda.Data
{
    public class DaldaContext : IdentityDbContext<AppUser,AppRole, int>
    {
        public DaldaContext(DbContextOptions<DaldaContext> options) : base(options)
        { }
    }
}