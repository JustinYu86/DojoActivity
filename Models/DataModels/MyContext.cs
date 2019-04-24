using Microsoft.EntityFrameworkCore;
using Activity = CSharpBelt.Models.Activity;
namespace CSharpBelt.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set;}
        public DbSet<Participate> Participates { get; set; }

    }
}