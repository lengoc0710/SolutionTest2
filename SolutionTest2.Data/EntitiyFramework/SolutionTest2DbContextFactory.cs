using Microsoft.EntityFrameworkCore.Design;
using SolutionTest2.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionTest2.Data.EntitiyFramework
{
    public class SolutionTest2DbContextFactory : IDesignTimeDbContextFactory<SolutionTest2DbContext>
    {
        public SolutionTest2DbContext CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
