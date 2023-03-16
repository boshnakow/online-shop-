using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CustomerBusiness
    {
        ProductContext productContext;

        public void Add(Customer customer)
        {
            using (productContext = new ProductContext())
            {
                productContext.Customers.Add(customer);
                productContext.SaveChanges();
            }
        }

        public List<Customer> ShowCustomers()
        {
            using (productContext = new ProductContext())
            {
                return productContext.Customers.ToList();
            }
        }
    }
}
