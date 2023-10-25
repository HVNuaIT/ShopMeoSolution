using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Domain.EF
{
    public class ShopMeoSolutionContextFactory : IDesignTimeDbContextFactory<ShopMeoDbContext>
    {
        public ShopMeoDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionstring = configuration.GetConnectionString("db");
            var optionBuider = new DbContextOptionsBuilder<ShopMeoDbContext>();
            optionBuider.UseSqlServer(connectionstring);
            return new ShopMeoDbContext(optionBuider.Options);
        }
    }
}
