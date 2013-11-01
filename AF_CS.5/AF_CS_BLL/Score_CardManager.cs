using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;
using AF_CS_DAL;

namespace AF_CS_BLL
{
   public class Score_CardManager
   {
       
       public ScoreCard ascoreCard { get; set; }
       private ICrud<ScoreCard> scoreDAO;
       public int resScore;


       public Score_CardManager()
       {
           scoreDAO = new DB_Score_Card_DAO();
       }


       public ScoreCard GetAll()
       {
           
           ascoreCard = scoreDAO.GetAll();
           return ascoreCard;
       }
       public int setScore(string res,string mar)
       {
           
           

           try
           {

               if (res == Convert.ToString("renting"))
               {
                   resScore = ascoreCard.renting_score;  
               }

               if (res == Convert.ToString("living with parents"))
               {
                   resScore = ascoreCard.living_with_parent_score;
               }
               
           }
           finally
           {
               ascoreCard.residentialscore = resScore;
           }
                  return resScore;
           
       }
    }
}
