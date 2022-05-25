using Microsoft.EntityFrameworkCore;

namespace RestCore5.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}