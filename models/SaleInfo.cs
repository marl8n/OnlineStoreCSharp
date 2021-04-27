using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerce.models
{
    public class SaleInfo
    {
        public string Id { get; set; }
        public string IdClient { get; set; }
        public string State { get; set; }
        public List<Product> Products { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}