using Core.Infrastructure.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Repository.Context
{
    public interface IAppContext
    {
        public DbSet<Departement> Depts { get; set; }
    }
}
