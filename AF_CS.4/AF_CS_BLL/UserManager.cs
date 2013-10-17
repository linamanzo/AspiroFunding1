using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;
using AF_CS_DAL;

namespace AF_CS_BLL
{
   public class UserManager
    { public User aUser { get; set; }

    public UserManager usermanager;
    public Personnal_DetailsManager persmanager;   
        private ICrud<User> UserDAO;


         public UserManager()
       {
           
          
       }
       
       public string GetStatusbyId(int id)
        {
            persmanager = new Personnal_DetailsManager(id);
      string marstat=  persmanager.GetMaritalStat(id);
      return  marstat; 
       }

       public string GetResStatus(int id )
   {  string restat = persmanager.GetResStatus(id);
       return restat;
       }
    

      
    }
}
