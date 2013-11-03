﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;


namespace AF_CS_BO
{
    public class ScoreCard
    {/*attributes from the database*/
        public int id_all_scores ;
        public int renting_score;
  public int living_with_parent_score ;
  public int owner_with_mortgage_score ;
 public int owner_with_no_mortgage_score ;
  
  public int single_score ;
  public int married_score ;
  public int divorced_score ;
  public int seperated_score ;
  
  public int under_21_score ;
  public int between_22_25 ;
  public int between_25_30 ;
  public int between_30_50 ;
  public int over_50;
  
  public int ccj_true_score ;
  public int ccj_false_score ;
  
  public int missed_repayment_true ;
  public int missed_repayment_false ;
   
  public int university_score_tier1 ;
  public int university_score_tier2 ;
  public int university_score_tier3 ;
  
  public int course_applied_score_tier1 ;
  public int course_applied_score_tier2 ;
  public int course_applied_score_tier3 ;

  public int course_1year_score ;
  public int course_2years_score ;
  public int course_3years_score ;
  
  public int part_time_score ;
  public int full_time_score ;
  public int distance_learning ;
  public int course_fees_score_under_10k ;
  public int course_fees_score_10_20k ;
  public int course_fees_score_20_30k ;
  public int course_fees_score_over_30k ;
  
  public int place_confirmed_score ;
  public int place_not_confirmed ;

  public int qualification_0_30_score ;
  public int qualification_30_60_score ;
  public int qualification_over60 ;
  
  public int job_confirmation_score ;
  public int job_not_confimed_score ;
  
  public int expected_salary_under_15k ;
  public int expected_salary_15_25k ;
  public int expected_salary_25_50k ;
  public int expected_salary_over_50k ;
  
  public int grade_AA_score ;
  public int grade_A_score ;
  public int grade_B_score ;
  public int grade_grey_score;





        /* local variables for the score calculation in the manager -  not going to the database yet*/
  public int coursescore;
  public int uniscore;

  public int financialscore;
  public int ccjscore;
  public int repaymentscore;

        
        public int personalscore;
        public int residentialscore;
        public int maritalscore;
        public int agescore;

        public ScoreCard()
        {
        }


       
        //[Flags]
        //public enum resStatus
        //{

        //    owner_with_mortgage = 10,
        //    owner_with_no_mortgage = 40,
        //    renting = 10,
        //    living_with_parents = 20


        //}

        //[Flags]
        //public enum marStat
        //{   
            
            
        //    seperated =10,
        //    married = 30,
        //    single	= 10,
        //    divorced =	0,

        //}

        //public int SetScore(string res, string mar, out int score )
        //{

        //    try
        //    {
        //        if (res == Convert.ToString(resStatus.owner_with_mortgage))
        //        {
        //            residentialscore= (int)resStatus.owner_with_mortgage;
                     
        //        }
        //        if (res == Convert.ToString(resStatus.renting))
        //        {
                    
        //           residentialscore     = (int)resStatus.renting;
                    
        //        }
        //        if (res == Convert.ToString(resStatus.living_with_parents))
        //        {
                    
        //           residentialscore     = (int)resStatus.living_with_parents;
                     
        //        }
        //        if (res == Convert.ToString(resStatus.owner_with_no_mortgage))
        //        {
                   
        //              residentialscore   = (int)resStatus.owner_with_no_mortgage;
                    
        //        }
        //        if ( mar.Equals(Convert.ToString(marStat.single)))
        //        {
        //              maritalscore= (int)marStat.single;
                    
        //        }
        //        if (mar == Convert.ToString(marStat.married))
        //        {
        //           maritalscore  = (int)marStat.married;
                    
        //        }
        //        if (mar == Convert.ToString(marStat.seperated))
        //        {
        //            maritalscore= (int)marStat.seperated;
                     
        //        }
        //        if (mar == Convert.ToString(marStat.divorced))
        //        {
        //           maritalscore  = (int)marStat.divorced;
                     
        //        }

        //       personalscore= score = residentialscore + maritalscore;
        //    }
        //    finally
        //    {
        //    } return personalscore;
        //}
        
    }

    
}