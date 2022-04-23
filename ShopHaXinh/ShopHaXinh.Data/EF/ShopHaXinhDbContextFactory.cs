using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShopHaXinh.Data.EF
{
    public class ShopHaXinhDbContextFactory : IDesignTimeDbContextFactory<ShopHaXinhDbContext>
    {
        public ShopHaXinhDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShopHaXinhDb"); 

            var optionsBuilder = new DbContextOptionsBuilder<ShopHaXinhDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopHaXinhDbContext(optionsBuilder.Options);
        }
    }
}
