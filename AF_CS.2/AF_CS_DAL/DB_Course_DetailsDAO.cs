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
   public class DB_Course_DetailsDAO : DB_DAO<Course_Details>
   {
       public DB_Course_DetailsDAO()
       {
           cmdGetAll = "SELECT * FROM coursedetails";
           cmdGetBy = "SELECT * FROM coursedetails WHERE @id = iDcd";
           cmdGetScore = "SELECT coursescore FROM coursedetails WHERE @id= iDcd";
           cmdInsert = String.Empty;
       }

       protected override void ObjectToParameters(Course_Details obj, NpgsqlCommand command)
       {
           throw new NotImplementedException();
       }

       protected override Course_Details ReaderToObject(NpgsqlDataReader dr)
       {
           try
           {
               Course_Details thiscoursed = new Course_Details();
               thiscoursed.iDcd = Convert.ToInt32(dr[0]);
               thiscoursed.courseDuration = Convert.ToInt32(dr[1]);
               thiscoursed.courseFees = Convert.ToInt32(dr[2]);
               thiscoursed.courseScore = Convert.ToInt32(dr[3]);
               thiscoursed.partFullTime = Convert.ToString(dr[4]);
               thiscoursed.placeConfirmed = Convert.ToBoolean(dr[5]);
               return thiscoursed;
           }
           catch
           {
               throw new NotImplementedException();
           }
       }
       protected override void IdToParameter(object id, NpgsqlCommand command)
       {
           command.Parameters.Clear();
           int idcoursdet = (int)id;
           NpgsqlParameter dbparcourse = command.CreateParameter();
           dbparcourse.DbType = System.Data.DbType.Int32;
           dbparcourse.Direction = System.Data.ParameterDirection.Input;
           dbparcourse.ParameterName = "@idcoursedr";
           dbparcourse.Value = idcoursdet;
           command.Parameters.Add(dbparcourse);

       }

       protected int GetScore(object id)
       {
           Course_Details coursd = base.GetScores(id);
           return coursd.courseScore;
       }


    }
}
