using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Mart
{
    public class AppData
    {
        public int LoginCustomerID { get; set; }
        public List<CustomerCartItem> CustomerCart { get; set; }
    }

    public class CustomerCartItem
    {
        public int ProductID { get; set; }
        public int Qty { get; set; }
    }
}
