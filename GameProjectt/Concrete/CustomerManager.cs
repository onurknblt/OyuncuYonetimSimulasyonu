using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt.Concrete
{
    internal class CustomerManager: ICustomerServise
    {
        private IUserVerifyService _userVerifyService;

        public CustomerManager(IUserVerifyService userVerifyService)
        {
            _userVerifyService = userVerifyService;
        }

        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Added.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Deleted.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Updated.");
        }
    }
}
