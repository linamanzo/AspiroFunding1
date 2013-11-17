using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;

namespace AF_CS_BO
{
   public class User
    {
        public int idUser {get; set;}
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string hashedPassword { get; set; }
        public string salt { get; set; }
        public string type { get; set; }
        public bool admin { get; set; }

       
       
    }
}
