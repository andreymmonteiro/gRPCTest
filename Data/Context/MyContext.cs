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
                    id = Guid.NewGuid(),
                    name = "Andrey Monteiro",
                    email = "andreymuti@hotmail.com",
                    age = 29,
                    document = "9106989784",
                    createDate = DateTime.Now,
                    password = "masterkey",
                    companyOrPerson = 'F'
                });
        }
    }
}
