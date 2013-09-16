using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;
using AF_CS_DAL;

namespace AF_CS_BLL
{
   public class Personnal_DetailsManager
    { 
       public Personnal_Details apersD { get; set; }
        private Personnal_DetailsManager persDmanager;
       
        private ICrud<Personnal_Details> persdDAO;
       // DAL Access
       
       public Personnal_DetailsManager()
        {
            persdDAO = new DB_Personnal_Details_DAO();
       }
       public Personnal_DetailsManager(Personnal_Details persd)
       {
           apersD = persd;
       }

       //public int GetScore()
       //{
       //}
    }
}
