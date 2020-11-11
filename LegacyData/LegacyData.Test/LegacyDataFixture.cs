using LegacyData.Dal.DataInitialization;
using LegacyData.Dal.EfStructures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyData.Test
{
    public class LegacyDataFixture : IDisposable
    {
        public LegacyDataContext context;
        public LegacyDataFixture()
        {
            context = new LegacyDataContextFactory().CreateDbContext(new string[] { });
            context.Database.Migrate();
            LegacyDataInitializer.InitializeData(context);
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
