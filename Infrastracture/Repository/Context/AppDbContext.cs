using Core.Infrastructure.Repository.Context;
using Core.Infrastructure.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Repository.Context
{
    public class AppDbContext : DbContext,IAppContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Departement> Depts { get; set; }
    }
}
