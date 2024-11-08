using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
//id,unit price,quantity,title,description,image url
{
    public class Product
    {
        public int ProductId { get; set; } //auto property
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }

    }
}
