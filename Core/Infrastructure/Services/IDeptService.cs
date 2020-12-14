using Core.Infrastructure.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Services
{
    public interface IDeptService
    {
        IResponse GetAll(Search search);
        IResponse GetById(int id);
        IResponse Create(CreateDept model);
        IResponse Delete(int id);
    }
}
