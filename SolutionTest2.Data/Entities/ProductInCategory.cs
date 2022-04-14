using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionTest2.Data.Entities
{ public class ProductInCategory
    {
        //Create foreign key to affiliate product and category
        public int ProductId { get; set; }

        public ProductTest ProductTest { get; set; }

        public int CategoryId { get; set; }

        public CategoryTest CategoryTest { get; set; }
    }
}
