using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierreBakery.Models
{
    public class PierreBakeryContextPierreBakery : IDesignTimeDbContextPierreBakery<PierreBakeryContext>
    {
        PierreBakeryContext IDesignTimeDbContextPierreBakery<PierreBakeryContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<PierreBakeryContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new PierreBakeryContext(builder.Options);
        }
    }
}