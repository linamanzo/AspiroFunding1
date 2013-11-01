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
       
       //public Personnal_DetailsManager()
       // {
       //     apersD = new Personnal_Details();
       //}

        public Personnal_DetailsManager()
        {
        }
       public Personnal_DetailsManager( int iDpersD)
       {   persdDAO = new DB_Personnal_Details_DAO();
          
       }

       public int GetScore(int iDpersD)
       {
           apersD = new Personnal_Details(iDpersD);
           int score = apersD.personnalScore;
           

           return score;
       }

       //public int setScore(string res)
       //{  apersD = new Personnal_Details();
       //apersD.residentialStatus = res; 
           
       //int  resscore=  apersD.SetScore(res);
       //return resscore;
           
       //} 
   

      

       public Personnal_Details GetPersStat(int id)

       { 
          apersD=   persdDAO.GetById(id);
             return apersD;
      
       }
       
    }
}
