using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyData.Dal.EfStructures
{
    public class LegacyDataContextFactory : IDesignTimeDbContextFactory<LegacyDataContext>
    {
        public LegacyDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LegacyDataContext>();
            var connectionString =
                @"Server=(localdb)\mssqllocaldb;Database=LegacyData;Trusted_Connection=True;MultipleActiveResultSets=true;";
            if (args.Length != 0)
            {
                connectionString = args[0];
            }
            optionsBuilder
                .UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
            Console.WriteLine(connectionString);
            return new LegacyDataContext(optionsBuilder.Options);
        }
    }
}
