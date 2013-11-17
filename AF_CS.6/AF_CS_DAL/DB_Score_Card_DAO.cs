using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;

using Npgsql;
using NpgsqlTypes;
namespace AF_CS_DAL
{
   public class DB_Score_Card_DAO : DB_DAO<ScoreCard>
    {public DB_Score_Card_DAO()
       {
           cmdGetAll = "SELECT * FROM allscor";
           cmdInsert = "UPDATE creditscore SET (personnalscore)  = (@pscore) WHERE idcreditscore = @id" ;
          
       }

       protected override void ObjectToParameters(object id ,ScoreCard obj, NpgsqlCommand command)
       {
           //command.Parameters.Clear();
        int  idcreditscore =(int) id;
           NpgsqlParameter dbparsc = command.CreateParameter();
           dbparsc.DbType = System.Data.DbType.Int32;
           dbparsc.Direction = System.Data.ParameterDirection.Input;
           dbparsc.ParameterName = "@id";
           dbparsc.Value = idcreditscore;
           command.Parameters.Add(dbparsc);


           NpgsqlParameter pscore = command.CreateParameter();
       pscore.DbType = System.Data.DbType.Int32;
        pscore.Direction = System.Data.ParameterDirection.Input;
        pscore.ParameterName = "@pscore";
         
        pscore.Value =  obj.scpScore;
 
        command.Parameters.Add(pscore);
       }
       protected override ScoreCard ReaderToObject(NpgsqlDataReader dr)
       {
           try
           {
               ScoreCard thisscorecard = new ScoreCard();
               thisscorecard.id_all_scores = Convert.ToInt32(dr[0]);
               thisscorecard.renting_score = Convert.ToInt32(dr[1]);
               thisscorecard.living_with_parent_score = Convert.ToInt32(dr[2]);
               thisscorecard.owner_with_mortgage_score = Convert.ToInt32(dr[3]);
               thisscorecard.owner_with_no_mortgage_score = Convert.ToInt32(dr[4]);
               thisscorecard.single_score = Convert.ToInt32(dr[5]);
               thisscorecard.married_score = Convert.ToInt32(dr[6]);
               thisscorecard.divorced_score = Convert.ToInt32(dr[7]);
               thisscorecard.seperated_score = Convert.ToInt32(dr[8]);
               thisscorecard.under_21_score = Convert.ToInt32(dr[9]);
               thisscorecard.between_22_25 = Convert.ToInt32(dr[10]);
               thisscorecard.between_25_30 = Convert.ToInt32(dr[11]);
               thisscorecard.between_30_50 = Convert.ToInt32(dr[12]);
               thisscorecard.over_50 = Convert.ToInt32(dr[13]);
               thisscorecard.ccj_true_score = Convert.ToInt32(dr[14]);
               thisscorecard.ccj_false_score = Convert.ToInt32(dr[15]);
               thisscorecard.missed_repayment_true = Convert.ToInt32(dr[16]);
               thisscorecard.missed_repayment_false = Convert.ToInt32(dr[17]);
               thisscorecard.university_score_tier1 = Convert.ToInt32(dr[18]);
               thisscorecard.university_score_tier2 = Convert.ToInt32(dr[19]);
               thisscorecard.university_score_tier3 = Convert.ToInt32(dr[20]);
               thisscorecard.course_applied_score_tier1 = Convert.ToInt32(dr[21]);
               thisscorecard.course_applied_score_tier2 = Convert.ToInt32(dr[22]);
               thisscorecard.course_applied_score_tier3 = Convert.ToInt32(dr[23]);
               thisscorecard.course_1year_score = Convert.ToInt32(dr[24]);
               thisscorecard.course_2years_score = Convert.ToInt32(dr[25]);
               thisscorecard.course_3years_score = Convert.ToInt32(dr[26]);
               thisscorecard.part_time_score = Convert.ToInt32(dr[27]);
               thisscorecard.full_time_score = Convert.ToInt32(dr[28]);
               thisscorecard.distance_learning = Convert.ToInt32(dr[29]);
               thisscorecard.course_fees_score_under_10k = Convert.ToInt32(dr[30]);
               thisscorecard.course_fees_score_10_20k = Convert.ToInt32(dr[31]);
               thisscorecard.course_fees_score_20_30k = Convert.ToInt32(dr[32]);
               thisscorecard.course_fees_score_over_30k = Convert.ToInt32(dr[33]);
               thisscorecard.place_confirmed_score = Convert.ToInt32(dr[34]);
               thisscorecard.place_not_confirmed = Convert.ToInt32(dr[35]);
               thisscorecard.qualification_0_30_score =Convert.ToInt32(dr[36]);
               thisscorecard.qualification_30_60_score = Convert.ToInt32(dr[37]);
               thisscorecard.qualification_over60 = Convert.ToInt32(dr[38]);
               thisscorecard.job_confirmation_score = Convert.ToInt32(dr[39]);
               thisscorecard.job_not_confimed_score = Convert.ToInt32(dr[40]);
               thisscorecard.expected_salary_under_15k = Convert.ToInt32(dr[41]);
               thisscorecard.expected_salary_15_25k = Convert.ToInt32(dr[42]);
               thisscorecard.expected_salary_25_50k = Convert.ToInt32(dr[43]);
               thisscorecard.expected_salary_over_50k = Convert.ToInt32(dr[44]);
               thisscorecard.grade_AA_score = Convert.ToInt32(dr[45]);
               thisscorecard.grade_A_score = Convert.ToInt32(dr[46]);
               thisscorecard.grade_B_score = Convert.ToInt32(dr[47]);
               thisscorecard.grade_grey_score = Convert.ToInt32(dr[48]);

               return thisscorecard;
           }
           catch
           {
               throw new NotImplementedException();
           }
       }
       protected override void IdToParameter(object id, NpgsqlCommand command)
       {
           command.Parameters.Clear();
           int idscorecard = (int)id;
           NpgsqlParameter dbparsc = command.CreateParameter();
           dbparsc.DbType = System.Data.DbType.Int32;
           dbparsc.Direction = System.Data.ParameterDirection.Input;
           dbparsc.ParameterName = "@id";
           dbparsc.Value = idscorecard;
           command.Parameters.Add(dbparsc);

       }

       public override ScoreCard GetAll()
       {

          ScoreCard scores = base.GetAll();

           return scores;
       }



    }
    }

