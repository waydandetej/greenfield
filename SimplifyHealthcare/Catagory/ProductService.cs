using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    public class ProductService : IProductService
    {
        public Product Get(int id)
        {
            return new Product { Id = 1, Name = "abc", Description = "asdf", UnitPrice = 12, Quantity = 10, Image = "/Images/rose.jpg" };
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "abc", Description = "asdf", UnitPrice = 12, Quantity = 10, Image = "/Images/rose.jpg" });
            products.Add(new Product { Id = 1, Name = "abc", Description = "asdflllll", UnitPrice = 12, Quantity = 10, Image = "/Images/rose1.jpg" });
            products.Add(new Product { Id = 1, Name = "abc", Description = "asdf", UnitPrice = 12, Quantity = 10, Image = "/Images/rose2.jpg" });

            return products;
        }

        public bool Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id) {
            throw new NotImplementedException();
        }
    }
}
