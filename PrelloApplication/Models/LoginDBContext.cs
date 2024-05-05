using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace PrelloApplication.Models
{
    public class LoginDBContext : IdentityDbContext<IdentityUser>
    {
        public LoginDBContext(DbContextOptions<LoginDBContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Users.sqlite");
        }
    }
}
