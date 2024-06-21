using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt.Concrete
{
    internal class SaleManager: ISaleService
    {
        public void Sale(Customer customer, Campaign campaign, Sale sale)
        {
            int discount = campaign.DiscountRate;
            sale.Price = sale.Price * discount / 100;
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " adlı kullanıcıya "
                + sale.GameName + " oyunu için " + campaign.CampaingnName + " uygulanmıştır. Fiyatı " + sale.Price + " TL.");
        }
    }
}

