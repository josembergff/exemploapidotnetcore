using ApiCoreEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCoreEntity.Base
{
    public class MyContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
    }
}