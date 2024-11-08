using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCOLib;
using Specification;
using BinaryDataRepositoryLib;

namespace Services
{
    public class ProductService : IProductService
    {
        public Product Get(int id)
        {
            Product foundProduct = null;
            List<Product> products = GetAll();

        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            //call logic of binary repo
            IDataRepository repository = new BinaryRepository();
            products = repository.Deserialize("product.dat");


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
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
