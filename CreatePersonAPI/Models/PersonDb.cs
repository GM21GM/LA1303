using Microsoft.EntityFrameworkCore;

namespace CreatePersonAPI.Models
{
    public class PersonDb : DbContext
    {
        public PersonDb(DbContextOptions<PersonDb> options) : base(options)
        {

        }
        
        public DbSet<Person> Person { get; set; }

       
    }
}
