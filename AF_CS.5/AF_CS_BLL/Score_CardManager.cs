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
       
       public Score_CardManager()
       {
       }

       public int setScore(string res,string mar)
       {
           int score;
           ascoreCard = new ScoreCard();
           int resscore = ascoreCard.SetScore(res,mar, out score);
           return resscore;
       }
    }
}
