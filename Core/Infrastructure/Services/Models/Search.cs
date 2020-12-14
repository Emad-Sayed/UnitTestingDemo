using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Services.Models
{
    public class Search
    {
        public string keyWord { get; set; }
        public int pageNumber { get; set; } = 1;
        public int pageSize { get; set; } = 10;
    }
}
