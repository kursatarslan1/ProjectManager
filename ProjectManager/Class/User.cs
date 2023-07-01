using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Class
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Explaination { get; set; }
        public DateTime Birthday { get; set; }
        public byte[] Photo { get; set; }
        public string PhoneNumber { get; set; }
    }
}
