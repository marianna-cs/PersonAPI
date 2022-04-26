using Microsoft.EntityFrameworkCore;
using PersonAPI.Data;

namespace PersonAPI.Repo
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    GID =Guid.NewGuid(),
                    FirstName = "Oleg",
                    LastName = "Drodov"
                },
                new Person
                {
                    Id = 2,
                    GID = Guid.NewGuid(),
                    FirstName = "Masha",
                    LastName = "Ivanova"
                },
                new Person
                {
                    Id = 3,
                    GID = Guid.NewGuid(),
                    FirstName = "Ivan",
                    LastName = "Ivanov"
                }
                );
        }

       /** Person p1 = new Person()
        {
            GID = Guid.NewGuid(),
            FirstName = "Masha",
            LastName = "Ivanova"
        };

        Person p2 = new Person()
        {
            GID = Guid.NewGuid(),
            FirstName = "Ivan",
            LastName = "Ivanov"
        };**/
    }
}
