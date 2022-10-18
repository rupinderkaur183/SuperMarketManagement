using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarketManagement.Models
{
    public class Subcategory
    {

        public int SubcategoryId { get; set; }
        public string? SubcategoryName { get; set; }
        public decimal? SubcategoryPrice { get; set; }
        public string? SubcategoryDescription { get; set; }
        public string? SubcategoryImage { get; set; }

    }
}
