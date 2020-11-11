using LegacyData.Dal.EfStructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;

namespace LegacyData.Dal.DataInitialization
{
    public class LegacyDataInitializer
    {
        public static void InitializeData(LegacyDataContext context)
        {
            //Ensure the database exists and is up to date, can't drop dbs in the cloud
            //context.Database.EnsureDeleted();
            context.Database.Migrate();
            ClearData(context);
            SeedData(context);
        }

        internal static void SeedData(LegacyDataContext context)
        {
            //Copy this if block and make one for your DBSet
            if (!context.PassportInactiveAllDatas.Any())
            {
                try
                {
                    IExecutionStrategy strategy = context.Database.CreateExecutionStrategy();
                    strategy.Execute(() =>
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT LegacyData.CP01PassportInactiveAllData" + " ON");
                            context.PassportInactiveAllDatas.AddRange(Data.GetPassportInactiveAllDatas());
                            context.SaveChanges();
                            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT LegacyData.CP01PassportInactiveAllData" + " OFF");
                            transaction.Commit();
                        }
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            if (!context.VTAInactiveAllDatas.Any())
            {
                try
                {
                    IExecutionStrategy strategy = context.Database.CreateExecutionStrategy();
                    strategy.Execute(() =>
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT LegacyData.CP01VTAInactiveAllData" + " ON");
                            context.VTAInactiveAllDatas.AddRange(Data.GetVTAInactiveAllDatas());
                            context.SaveChanges();
                            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT LegacyData.CP01VTAInactiveAllData" + " OFF");
                            transaction.Commit();
                        }
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            if (!context.TestNewClasses.Any())
            {
                try
                {
                    IExecutionStrategy strategy = context.Database.CreateExecutionStrategy();
                    strategy.Execute(() =>
                    {
                        using (var transaction = context.Database.BeginTransaction())
                        {
                            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT LegacyData.TestNewClass" + " ON");
                            context.TestNewClasses.AddRange(Data.GetNewTestClasses());
                            context.SaveChanges();
                            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT LegacyData.TestNewClass" + " OFF");
                            transaction.Commit();
                        }
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        private static void ClearData(LegacyDataContext context)
        {
            //Copy one of these and replace with your table name
            context.Database.ExecuteSqlRaw("Delete from LegacyData.CP01PassportInactiveAllData");
            context.Database.ExecuteSqlRaw("Delete from LegacyData.CP01VTAInactiveAllData");
            context.Database.ExecuteSqlRaw("Delete from LegacyData.TestNewClass");

            ResetIdentity(context);
        }

        internal static void ResetIdentity(LegacyDataContext context)
        {
            var tables = new[]
            {
                //add your table here
                "CP01VTAInactiveAllData",
                "CP01PassportInactiveAllData",
                "TestNewClass"
            };
            foreach (var itm in tables)
            {
                var rawSqlString = $"DBCC CHECKIDENT (\"LegacyData.{itm}\", RESEED, 0);";
                context.Database.ExecuteSqlRaw(rawSqlString);
            }
        }
    }
}
