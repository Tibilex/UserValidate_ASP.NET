using Microsoft.EntityFrameworkCore;

namespace UserValidate_ASP.NET.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //builder.UseSqlServer("Data Source=SQL8001.site4now.net,1433;Initial Catalog=db_a8dfe9_aspdb;User Id=db_a8dfe9_aspdb_admin;Password=Bozic901;");
            builder.UseSqlServer("Data Source=DESKTOP-440KLQF\\SQLEXPRESS;Initial Catalog=Asp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }
    }
}
