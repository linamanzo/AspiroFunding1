using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF_CS_BO
{
   public class User
    {
        public int idUser;
        public string username;
        public string firstName;
        public string lastName;
        public string email;
        public string hashedPassword;
        public string salt;
        public string type;
        public bool admin;
    }
}
