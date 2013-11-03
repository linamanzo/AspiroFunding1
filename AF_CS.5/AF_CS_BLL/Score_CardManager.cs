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
       public int persScore;
       public int resScore;
       public int marScore;
       public int ageScore;

       public int finScore;
       public int ccjScore;
       public int repScore;
       
       public int finalScore;


       /*******/
       public int residscore;



       /*Creating a new Data Access Object to link with the database*/
     
       public Score_CardManager()
       { /*scoreDAO in comment to test the Dictionary*/
           //scoreDAO = new DB_Score_Card_DAO();
       }

       /*Loading all scores from database*/
       public ScoreCard GetAll()
       {
           
           ascoreCard = scoreDAO.GetAll();
           return ascoreCard;
       }

       /*Setting Final Score*/
       public int setScore(string res, string mar, string age, string ccj, string repayment)
       {
          persScore = this.setPersonnalScore(res, mar, age);
          finScore = this.setFinancialScore(ccj, repayment);
           int  finalScore = persScore + finScore;
           return finalScore;
   }


       /*Setting Personal Score*/
       public int setPersonnalScore(string res, string mar, string age)
       {
           this.setResidentialScore(res);
           this.setMaritalScore(mar);
           this.setAgeScore(age);
           //int persScore = ascoreCard.residentialscore + ascoreCard.maritalscore + ascoreCard.agescore  ;
           int persScore = resScore + marScore + ageScore;
           return persScore;

       }
       /*Setting Age Score*/
       public int setAgeScore(string age)
       {
           try
           {
               int i = Convert.ToInt32(age);
               if (  i< 21 )
               {
                   ageScore = ascoreCard.under_21_score;
               }

               if (i >= 22 && i<25)
               {
                   ageScore = ascoreCard.between_22_25;
               }

               if (i >= 25 && i<30)
               {
                   ageScore = ascoreCard.between_25_30;
               }

               if (i >= 30 && i<50)
               {
                  ageScore = ascoreCard.between_30_50;
               }

               if (i >= 50)
               {
                   ageScore = ascoreCard.over_50;
               }


           }
           finally
           {
               //ascoreCard.agescore = ageScore;
           }
           return ageScore;
       }
       /* setting Marital Score*/
       public int setMaritalScore(string mar)
       {
           try
           {

               if (mar == Convert.ToString("single"))
               {
                   marScore = ascoreCard.single_score;
               }

               if (mar == Convert.ToString("married"))
               {
                   marScore = ascoreCard.married_score;
               }

               if (mar == Convert.ToString("seperated"))
               {
                   marScore = ascoreCard.seperated_score;
               }

               if (mar == Convert.ToString("divorced"))
               {
                   marScore = ascoreCard.divorced_score;
               }


           }
           finally
           {
               //ascoreCard.maritalscore = marScore;
           }
           return marScore;
       }
       /* Setting Residential Score */
       public int setResidentialScore(string res)
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
               
               if (res == Convert.ToString("owner with mortgage"))
               {
                   resScore = ascoreCard.owner_with_mortgage_score;
               }
              
               if (res == Convert.ToString("owner without mortgage"))
               {
                   resScore = ascoreCard.owner_with_no_mortgage_score;
               }


           }
           finally
           {
               //ascoreCard.residentialscore = resScore;
           }
                  return resScore;
           
       }

       /*Setting Financial Score*/
       public int setFinancialScore(string ccj, string repayment)
       {
         this.setCcjScore(ccj);
         this.setRepaymentScore(repayment);
           
           return finScore;
       }
       /*Setting CCJ Score*/
       public int setCcjScore(string ccj)
       {try
           {
                
               if (ccj == Convert.ToString("True"))
               {
                   ccjScore = ascoreCard.ccj_true_score;
               }

               if (ccj == Convert.ToString("False"))
               {
                   ccjScore = ascoreCard.ccj_false_score;
               }
           }
       finally
       {
           //ascoreCard.ccjscore = ccjScore;
       }
       return ccjScore;
       }

       public int setRepaymentScore(string repayment)
       {
           try
           {

               if (repayment == Convert.ToString("True"))
               {
                   repScore = ascoreCard.missed_repayment_true;
               }

               if (repayment == Convert.ToString("False"))
               {
                   repScore = ascoreCard.missed_repayment_false;
               }
           }
           finally
           {
               //ascoreCard.repaymentscore = repScore;
           }
           return repScore;
       }


       public int setscoredict(string res)
       {
           ascoreCard = new ScoreCard();
          residscore= ascoreCard.setsResScoreDict(res);
          return residscore;
       }
    }
}
