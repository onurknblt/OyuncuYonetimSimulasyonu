using GameProjectt.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt.Concrete
{
    internal class UserVerifyManager: IUserVerify
    {
        public bool Verify(Customer customer)
        {
            // Check the customer properties for validation
            if (customer.DateOfBirth == new DateTime(2002, 1, 1) &&
                customer.FirstName == "Yusuf Ali" &&
                customer.LastName == "Öztürk" &&
                customer.Id == 123)
            {
                return true;
            }

            return false;
        }
    }
}
