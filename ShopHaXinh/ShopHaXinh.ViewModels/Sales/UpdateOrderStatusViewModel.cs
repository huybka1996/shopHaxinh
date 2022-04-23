using ShopHaXinh.ViewModels.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHaXinh.ViewModels.Sales
{
    public class UpdateOrderStatusViewModel
    {
        public int OrderId { get; set; }
        public OrderStatus status { get; set; }
    }
}
