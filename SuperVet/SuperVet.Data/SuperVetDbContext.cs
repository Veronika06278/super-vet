using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SuperVet.Data
{
    public class SuperVetDbContext : IdentityDbContext
    {
        public SuperVetDbContext(DbContextOptions<SuperVetDbContext> options)
            : base(options)
        {
        }
    }
}
