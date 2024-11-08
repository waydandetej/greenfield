using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using CRM;


namespace ECommerceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Tejas";
            customer1.LastName = "Waydande";
            customer1.Email= "tejas.waydande@gmail.com";
            customer1.Contact = "9876546789";

            ICustomerService customerService = new CustomerService();
            customerService.Insert(customer1);
           
            List<Customer> customerlist = customerService.GetAll();
            foreach(Customer customer in customerlist)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.Contact);

                    
            }
           // product1.ProductId = 1;
           // product1.UnitPrice=100;
           // Product product1 = new Product();  //id,unit price,quantity,title,description,image url
           // product1.Quantity = 4;
           // product1.Title = "product1";
           // product1.Description= "abcd";
           // product1.ImageUrl = "fafdsfdfs.jpg";
           //
           // IProductService productservice = new ProductService();
           // productservice.Insert(product1);
           //
           // List<Product>productlist = productservice.GetAll();
           // foreach (Product product in productlist)
           // {
           //     Console.WriteLine(product.UnitPrice);
           //     Console.WriteLine(product.Quantity);
           //     Console.WriteLine(product.Title);
           //     Console.WriteLine(product.Description);
           //     Console.WriteLine(product.ImageUrl);
           //
           //
           // }


            Console.ReadLine();         
            
        }
    }
}
