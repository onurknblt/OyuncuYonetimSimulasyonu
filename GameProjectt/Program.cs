using GameProjectt.Concrete;
using GameProjectt.Entities;

namespace GameProjectt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Customer customer1 = new Customer();
                customer1.Id = 1864;
                customer1.FirstName = "Onur";
                customer1.LastName = "Kanbolat";
                customer1.DateOfBirth = new DateTime(2001, 10, 25); // Corrected to a valid DateTime
                customer1.Identity = "2021469025";

                Campaign campaign1 = new Campaign()
                {
                    CampaingnName = "%32 İndirim!", // Corrected the property name
                    DiscountRate = 50
                };

                Sale sale1 = new Sale()
                {
                    OrderNo = 1,
                    GameName = "Valorant",
                    Price = 110

                };

                CustomerManager customerManager1 = new CustomerManager(new UserVerifyManager());
                customerManager1.Add(customer1);

                CampaignManager campaignManager1 = new CampaignManager();
                campaignManager1.Update(campaign1);

                SaleManager saleManager1 = new SaleManager();
                saleManager1.Sale(customer1, campaign1, sale1);


            }
        }
    }
}
