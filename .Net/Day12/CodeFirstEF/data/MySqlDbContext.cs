using CodeFirstEF.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.data
{
    public class MySqlDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) 
            : base(options)
        {
        }

    }

}
