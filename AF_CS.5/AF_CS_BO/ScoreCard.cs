using System;
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
  //public int coursescore;
  //public int uniscore;

  //public int financialscore;
  //public int ccjscore;
  //public int repaymentscore;

        
  //public int personalscore; 
  //public int maritalscore;
  //public int agescore;

  public int marital;
  public int ageScore;
public int residential;
        public ScoreCard()
        {
        }


         /******************************************************************************/
        private static readonly Dictionary<string, int> residentialStatuses
    = new Dictionary<string, int>
        
    {
         
       { "owner with no mortgage", 40},
        {"owner with mortgage", 10},
        {"living with parents", 20},
        {"renting", 10},
 

    };
        private static readonly Dictionary<string, int> maritalStatuses
            =new Dictionary<string,int>
            {
             {"single", 10} ,
               {" married", 30} ,
            {"  divorced", 0 },
            {"  seperated",10} ,
    };

        private static readonly Dictionary<string, int> Ages
= new Dictionary<string, int>
        
    {    {"under21",0},
        {"between2225",5},
        {"between2530",20},
        {"between3049",10},
        {"over50",0}
    
 

    };

        private static readonly Dictionary<string, int> TrueFalse
= new Dictionary<string, int>
        
    {
         
       { "True", 0},
        {"Fasle", -999},
       
 

    };


    //    private static readonly Dictionary<string, int> CCJSatuses
    //  = new Dictionary<string, int>
    //        {
        
    //         {"True", -999} ,
    //           {"False", 0} ,
         
    //};


    //    private static readonly Dictionary<string, int> RepaymentStatuses
    // = new Dictionary<string, int>
    //        {
        
    //         {"True", -999} ,
    //           {"False", 0} ,
         
    //};

        private static readonly Dictionary<string, int> UniversityTiers
     = new Dictionary<string, int>
            {
        
             {"Tier1",50 } ,
               {"Tier2", 20} ,
               {"Tier3", 10},
         
    };

        private static readonly Dictionary<string, int> CourseTiers
= new Dictionary<string, int>
            {
        
             {"Tier1",50 } ,
               {"Tier2", 20} ,
               {"Tier3", 10},
         
    };
        private static readonly Dictionary<string, int> CourseDuration
= new Dictionary<string, int>
            {
        
             {"1",30 } ,
               {"2", 30} ,
               {"3", 10},
         
    };

        private static readonly Dictionary<string, int> CourseType
= new Dictionary<string, int>
            {
        
             {"full time",30 } ,
               {"part time", 30} ,
               {"distance learning", 10},
         
    };
        private static readonly Dictionary<string, int> CourseFees
= new Dictionary<string, int>
            {
          {" under_10k", 20},
          {"10_20k ", 30},
          {"20_30k ",10} ,
    {"over_30k", 0},
          
         
    };

//        private static readonly Dictionary<string, int> PlaceConfirmation
//= new Dictionary<string, int>
        
//    {
         
//       { "True", 0},
//        {"Fasle", -999},
       
 

//    };

//        private static readonly Dictionary<string, int> JobConfirmation
//= new Dictionary<string, int>
        
//    {
         
//       { "True", 0},
//        {"Fasle", -999},
       
 

//    };
        private static readonly Dictionary<string, int> ExpectedSalary
= new Dictionary<string, int>
        
    {
         {"under15",0},
         {"15_25k",10},
         {"25_50k",30},
         {"over50",40},

       
 

    };

        private static readonly Dictionary<string, int> Grades
= new Dictionary<string, int>
        
    {
         
       { "AA", 300},
        {"A", 250},
        {"B",200 },
        {"grey",150},

    };


        public int setsResScoreDict(string res)
        {
            {
                 residential = residentialStatuses[res];
            }
            return residential;
        }


        public int setsMarScoreDict(string mar)
        {
            {
              marital   = maritalStatuses[mar];
            }
            return marital;
        }

        public int setsAgeScoreDict(string age)
        {
            try
            {
                int i = Convert.ToInt32(age);
                if (i < 21)
                {
                    ageScore = Ages[age];
                }

                if (i >= 22 && i < 25)
                {
                    ageScore = Ages[age];
                }

                if (i >= 25 && i < 30)
                {
                    age = "between2530";
                    ageScore = Ages[age];
                }

                if (i >= 30 && i < 50)
                {
                    ageScore = Ages[age];
                }

                if (i >= 50)
                {
                    ageScore = Ages[age];
                }


            }
            finally
            {
                //ascoreCard.agescore = ageScore;
            }
            return ageScore;
        }
      
        
    }

    
}