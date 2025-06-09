using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLand.Models
{
    public class CustomerModel
    {
        public int id_customer { get; set; }
        public string nama_lengkap { get; set; }
        public string alamat { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
