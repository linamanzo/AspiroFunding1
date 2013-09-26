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
        public int id;
       
        private ICrud<Personnal_Details> persdDAO;
       // DAL Access
       
       public Personnal_DetailsManager()
        { 
            
       }
       public Personnal_DetailsManager( int id)
       {   persdDAO = new DB_Personnal_Details_DAO();
          
       }

       public int GetScore(int id)
       {
           apersD = new Personnal_Details();
           int score = apersD.personnalScore;
           

           return score;
       }
    }
}
