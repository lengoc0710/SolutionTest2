﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SolutionTest2.Data.Entities
{
    [Table("ProdectTest")]
    public class ProductTest
    {
        public int ID { set; get; }
        public decimal Price { set; get; }
        public decimal FirstPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        [Required]
        //public string SeoAlias { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }

       public List<ProductTranslation> ProductTranslations { get; set; }

//        public List<ProductImage> ProductImages { get; set; }

    }
}
