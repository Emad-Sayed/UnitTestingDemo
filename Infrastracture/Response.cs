using Core.Infrastructure;
using System;

namespace Infrastracture
{
    public class Response : IResponse
    {
        public bool status { get; set; } = true;
        public string error_AR { get; set; }
        public string error_EN { get; set; }
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int pagesTotalNumber { get; set; }
        public int pagesTotalRows { get; set; }
        public object data { get; set; }
    }
}
