using JWT.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWT.Context
{
    public class AuthDemoDbContext: IdentityDbContext
    {
        public AuthDemoDbContext(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
