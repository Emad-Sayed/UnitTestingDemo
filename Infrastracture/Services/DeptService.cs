using Core.Infrastructure;
using Core.Infrastructure.Repository.Entities;
using Core.Infrastructure.Services;
using Core.Infrastructure.Services.Models;
using Infrastracture.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Infrastracture.Services
{
    public class DeptService : IDeptService
    {
        public readonly AppDbContext _context;
        public readonly IResponse _response;
        public DeptService(AppDbContext context, IResponse response)
        {
            _context = context;
            _response = response;
        }
        public IResponse Create(CreateDept model)
        {
            var newDept = new Departement() { DeptName = model.Name };
            _context.Depts.Add(newDept);
            _context.SaveChanges();
            _response.data = newDept;
            return _response;
        }

        public IResponse Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IResponse GetAll(Search search)
        {
            var selectedDepts = _context.Depts.ToList();
            _response.data = selectedDepts;
            return _response;
        }

        public IResponse GetById(int id)
        {
            var selectedDept = _context.Depts.FirstOrDefault(dept => dept.Id == id);
            var off = selectedDept.Offices;
            if (selectedDept == null)
                _response.status = false;
            else
                _response.data = selectedDept;
            return _response;
        }
    }
}
