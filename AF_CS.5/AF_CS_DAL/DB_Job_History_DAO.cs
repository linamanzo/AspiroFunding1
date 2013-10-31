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
  public class DB_Job_History_DAO: DB_DAO<Job_History>
    {
      public DB_Job_History_DAO()
       {
           cmdGetAll = "SELECT * FROM jobhistory";
           cmdGetBy = "SELECT * FROM jobhistory WHERE iduser = @id";
           cmdGetScore = "SELECT jobhistoryscore  FROM jobhistory WHERE iduser=@id";
           cmdInsert = String.Empty;
       }

       protected override void ObjectToParameters(Job_History obj, NpgsqlCommand command)
       {
           throw new NotImplementedException();
       }

       protected override Job_History ReaderToObject(NpgsqlDataReader dr)
       {
           try
           {
               Job_History thisjobh = new Job_History();
               thisjobh.iDjh = Convert.ToInt32(dr[0]);
               thisjobh.previouslyEmployed = Convert.ToString(dr[1]);
               thisjobh.previousSalary = Convert.ToInt32(dr[2]);
               thisjobh.jobDuration = Convert.ToInt32(dr[3]);
               thisjobh.jobHistoryScore = Convert.ToInt32(dr[4]);
               
              
               
               return thisjobh;
           }
           catch
           {
               throw new NotImplementedException();
           }
       }
       protected override void IdToParameter(object id, NpgsqlCommand command)
       {
           command.Parameters.Clear();
           int idjobh = (int)id;
           NpgsqlParameter dbparjobh = command.CreateParameter();
           dbparjobh.DbType = System.Data.DbType.Int32;
           dbparjobh.Direction = System.Data.ParameterDirection.Input;
           dbparjobh.ParameterName = "@id";
           dbparjobh.Value = idjobh;
           command.Parameters.Add(dbparjobh);

       }

       public override Job_History GetById(object id)
       {
           Job_History jobh = base.GetById(id);

           return jobh;
       }

    }
}
