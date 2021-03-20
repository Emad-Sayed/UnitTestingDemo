using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Repository.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public string OfficeName { get; set; }
        public virtual Departement Dept { get; set; }
    }
}
