using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=gRPCTest;Uid=root;Pwd=masterkey";
            var optinosBuilder = new DbContextOptionsBuilder<MyContext>();
            optinosBuilder.UseMySql(connectionString,
                            ServerVersion.Parse("5.7-mysql"),
                            options => options.EnableRetryOnFailure(5,TimeSpan.FromSeconds(10),null));

            return new MyContext(optinosBuilder.Options);
        }
    }
}
