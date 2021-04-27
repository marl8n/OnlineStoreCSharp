using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerce.models
{
    public class Client
    {
        public string Id { get; set; }
        public string Nit { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}