using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TestRamsay.Data;

namespace TestRamsay.API
{
    public class ContextFactory : IDesignTimeDbContextFactory<TestRamsayDBContext>
    {
        public TestRamsayDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<TestRamsayDBContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlite(connectionString, b => b.MigrationsAssembly("TestRamsay.API"));

            return new TestRamsayDBContext(builder.Options);
        }
    }
}