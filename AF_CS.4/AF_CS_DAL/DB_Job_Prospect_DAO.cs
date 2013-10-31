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
 public   class DB_Job_Prospect_DAO : DB_DAO<Job_Prospect>
    { public DB_Job_Prospect_DAO()
       {
           cmdGetAll = "SELECT * FROM jobprospect";
           cmdGetBy = "SELECT * FROM jobprospect WHERE iduser = @id";
           cmdGetScore = "SELECT prospectscore FROM jobprospect WHERE iduser=@id";
           cmdInsert = String.Empty;
       }

       protected override void ObjectToParameters(Job_Prospect obj, NpgsqlCommand command)
       {
           throw new NotImplementedException();
       }

       protected override Job_Prospect ReaderToObject(NpgsqlDataReader dr)
       {
           try
           {
               Job_Prospect thisjobp = new Job_Prospect();
               thisjobp.iDjp = Convert.ToInt32(dr[0]);
               thisjobp.jobConfirmed = Convert.ToBoolean(dr[1]);
               thisjobp.expectedSalary = Convert.ToInt32(dr[2]);
               thisjobp.prospectScore = Convert.ToInt32(dr[3]);
               
              
               
               return thisjobp;
           }
           catch
           {
               throw new NotImplementedException();
           }
       }
       protected override void IdToParameter(object id, NpgsqlCommand command)
       {
           command.Parameters.Clear();
           int idjobp = (int)id;
           NpgsqlParameter dbparjobp = command.CreateParameter();
           dbparjobp.DbType = System.Data.DbType.Int32;
           dbparjobp.Direction = System.Data.ParameterDirection.Input;
           dbparjobp.ParameterName = "@id";
           dbparjobp.Value = idjobp;
           command.Parameters.Add(dbparjobp);

       }

       public override Job_Prospect GetById(object id)
       {

           Job_Prospect jobp = base.GetById(id);

           return jobp;
       }


    }
    }

