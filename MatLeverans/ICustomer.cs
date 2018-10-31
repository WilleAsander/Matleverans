using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatLeverans
{
    public interface ICustomer
    {
        List<Customer> Add(string name, string socialSec, string adress, string email,string phone, bool VIP, int id,string date);
    }
}
