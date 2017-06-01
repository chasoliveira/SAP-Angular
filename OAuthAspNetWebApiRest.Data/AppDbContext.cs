using Microsoft.AspNet.Identity.EntityFramework;
using OAuthAspNetWebApiRest.Domain.Models;
using System.Data.Entity;

namespace OAuthAspNetWebApiRest.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Product> Products { get; set; }
        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
    }
}
