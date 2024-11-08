using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class CustomerService : ICustomerService
    {  
        List<Customer> _customerList;
        public CustomerService()
        {
            _customerList = new List<Customer>();
        }
          public bool Delete(int id)
        {
            Customer theCustomer = this.Get(id);
            return this._customerList.Remove(theCustomer);
        }
        public Customer Get(int id)
        {
            foreach (Customer customer in _customerList)
            {
                if(customer.Id == id) return customer;
            }
            return null;
        }

        public List<Customer> GetAll()
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { Id = 1, FirstName = "Tejas", LastName = "Waydande", Email ="tejas.waydande@gmail.com", Contact="7898675467" });
            return (customer);
        }

        public bool Insert(Customer customer)
        {
            this._customerList.Add(customer);
            return true;
        }

        public bool Update(Customer customer)
        {
            Customer theCustomer =this.Get(customer.Id);
            theCustomer.FirstName=customer.FirstName; 
            theCustomer.LastName=customer.LastName; 
            theCustomer.Email=customer.Email;
            theCustomer.Contact=customer.Contact;

            return true;
        }
    }
}
