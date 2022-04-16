using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SolutionTest2.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolutionTest2.Data.EntitiyFramework
{
    public class SolutionTest2DbContextFactory : IDesignTimeDbContextFactory<SolutionTest2DbContext>
    {
        public SolutionTest2DbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("SolutionTest2Db");
            var optionsBuilder = new DbContextOptionsBuilder<SolutionTest2DbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SolutionTest2DbContext(optionsBuilder.Options);
        }
    }
}
