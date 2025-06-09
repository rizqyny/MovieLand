using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLand
{
    public static class Session
    {
        public static Models.CustomerModel LoggedInCustomer { get; set; }
        public static string Username { get; set; }
        public static int IdCustomer { get; set; }
    }
}
