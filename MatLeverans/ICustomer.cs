using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatLeverans
{
    public interface ICustomer
    {
        string name { get; set; }
        string socialSec { get; set; }
        string adress { get; set; }
        string email { get; set; }
        string phone { get; set; }
        bool VIP { get; set; }
        string date { get; set; }
    }
}
