using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class ProductService : IProductService
    {
        List<Product> _productlist;
        public ProductService()
        {
            _productlist = new List<Product>();
        }
        public bool Delete(int id)
        {
            Product theProduct = this.Get(id);
            return this._productlist.Remove(theProduct);
        }
        public Product Get(int id)
        {
            foreach (Product product in _productlist)
            {
                if (Product.Id == id) return product;
            }
            return null;
        }
        
        public List<Product> GetAll()
        {
            return _productlist;
        }

        public bool Insert(Product product)
        {
            this._productList.Add(product);
            return true;
        }

        public bool Update(Product product)
        {
            Product theProduct = this.Get(product.Id);
            theProduct.UnitPrice = product.UnitPrice;
            theProduct.Quantity = product.Quantity;    //id,unit price,quantity,title,description,image url
            theProduct.Title = product.Title;
            theProduct.Description = product.Description;
            theProduct.ImageUrl = product.ImageUrl;

            return true;
        }
    }
}
