using Core.Infrastructure.Repository.Entities;
using Infrastracture.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace XUnitTestProject
{
    public static class SeedInMemory
    {
        public static void DoSeedInMemory(this AppDbContext context)
        {
            var selectedDepts = context.Depts.ToList();
            foreach(Departement dept in selectedDepts)
            {
                context.Remove(dept);
            }
            context.SaveChanges();
            context.Depts.Add(new Departement() {Id=1, DeptName = "Dept1" });
            context.Depts.Add(new Departement() {Id=2, DeptName = "Dept2" });
            context.Depts.Add(new Departement() {Id=3, DeptName = "Dept3" });
            context.Depts.Add(new Departement() {Id=4, DeptName = "Dept4" });
            context.SaveChanges();
        }
    }
}
