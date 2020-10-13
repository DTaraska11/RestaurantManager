using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace RestaurantManager
{
    public class User
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }


    }
}
