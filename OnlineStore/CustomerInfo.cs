using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OnlineStore
{
    class CustomerInfo
    {
        private static CustomerInfo customer_info;
        public static CustomerInfo getSample()
        {
            if (customer_info == null)
                customer_info = new CustomerInfo();
            return customer_info;
        }

        public int Customerid { get; set; }
        public string Customername { get; set; }
        public string Customeraddress { get; set; }
        public string Customeremail { get; set; }
        public string Customerusername { get; set; }
        public string Customerpassword { get; set; }
        public bool Customergender { get; set; }


    }
}
