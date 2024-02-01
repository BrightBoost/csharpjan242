using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Runtime.Intrinsics.X86;

namespace MyFirstAPI.Models
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions options): base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }

}
