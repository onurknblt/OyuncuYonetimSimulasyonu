using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt.Abstract
{
    internal class ISaleService
    {
        public void Sale(Customer customer, Campaign campaign, Sale sale);
    }
}
