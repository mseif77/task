using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Task1.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-O72JPNR\\SQLEXPRESS; Database=25DB;Integrated Security=True;TrustServerCertificate=True");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}