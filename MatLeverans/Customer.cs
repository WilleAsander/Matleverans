using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatLeverans
{
    public class Customer : ICustomer
    {
        public string name { get; set; }
        public string socialSec { get; set; }
        public string adress { get; set; }
        public string email { get ; set ; }
        public string phone { get ; set ; }
        public bool VIP { get ; set ; }
        public int id { get ; set ; }
        public string date { get ; set ; }

        public override string ToString()
        {
            return string.Format(name);
        }
    }
}
