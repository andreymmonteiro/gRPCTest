using Data.Mapping.User;
using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> User { get; set;  }
        public MyContext([NotNullAttribute] DbContextOptions<MyContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);

            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity() 
                {
                    Id = Guid.NewGuid(),
                    Name = "Andrey Monteiro",
                    Email = "andreymuti@hotmail.com",
                    Age = 29,
                    Document = "9106989784",
                    CreateDate = DateTime.Now,
                    Password = "masterkey",
                    CompanyOrPerson = 'F'
                });
        }
    }
}
