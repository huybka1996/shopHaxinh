using ShopHaXinh.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHaXinh.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public int? CategoryId { get; set; }
    }
}