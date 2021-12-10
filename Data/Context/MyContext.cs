using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
