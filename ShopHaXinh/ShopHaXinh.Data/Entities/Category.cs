using ShopHaXinh.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHaXinh.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
