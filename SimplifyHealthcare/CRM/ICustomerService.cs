using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public interface ICustomerService   //defining the prototype ,contract,specification
    {
        List<Customer> GetAll();
        Customer Get(int id);
        bool Insert (Customer customer);
        bool Update (Customer customer);
        bool Delete (int id);

    }
}
