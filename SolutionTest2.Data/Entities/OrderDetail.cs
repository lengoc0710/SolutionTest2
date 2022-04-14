using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionTest2.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public Order Order { get; set; }

        public ProductTest ProductTest { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }
    }
}
