using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using users_api.Users.Models;

namespace users_api.Data.Migrations
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){          
        }

        public virtual DbSet<User> Users { get; set; }

    }
}
