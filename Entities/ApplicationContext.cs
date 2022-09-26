using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Geekosphere_backend.Entities
{
    public class ApplicationContext: IdentityDbContext<Customer>
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
      : base(options)
        {
        }
        public DbSet<Customer>? Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>()
            .HasData(
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName= "Pierre",
                    LastName = "Sinègre",
                    UserName = "conquerpierre",
                    Email = "pierresinegre2@gmail.com",
                    Password = "Budbaptiste1#",
                    Age = 30
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FirstName= "Bud",
                    LastName= "Amiga",
                    UserName= "bud",
                    Email= "pierresinegre2@gmail.com",
                     Password = "Budbaptiste1#",
                    Age = 25
                }
            );
        }
    }
}
