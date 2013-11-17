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
   public class DB_Financial_Details_DAO :DB_DAO< Financial_Details>
    {
       public DB_Financial_Details_DAO()
       {
           cmdGetAll = "SELECT * FROM financialdetails";
           cmdGetBy = "SELECT * FROM financialdetails WHERE iduser = @id";
           cmdGetScore = "SELECT financialscore FROM financialdetails WHERE @id= iDfd";
           cmdInsert = String.Empty;
       }

       protected override void ObjectToParameters(object id,Financial_Details obj, NpgsqlCommand command)
       {
           throw new NotImplementedException();
       }

       protected override Financial_Details ReaderToObject(NpgsqlDataReader dr)
       {
           try
           {
               Financial_Details thisfinanciald = new Financial_Details();
               thisfinanciald.iDfd = Convert.ToInt32(dr[0]);
               thisfinanciald.ccj = Convert.ToBoolean(dr[1]);
              thisfinanciald.missedRepayment = Convert.ToBoolean(dr[2]);
              thisfinanciald.loanOutstanding= Convert.ToInt32(dr[3]);
              thisfinanciald.existingCreditCard = Convert.ToInt32(dr[4]);
               thisfinanciald.financialScore = Convert.ToInt32(dr[5]);
              
               
               return thisfinanciald;
           }
           catch
           {
               throw new NotImplementedException();
           }
       }
       protected override void IdToParameter(object id, NpgsqlCommand command)
       {
           command.Parameters.Clear();
           int idfinancialdet = (int)id;
           NpgsqlParameter dbparfinancial = command.CreateParameter();
           dbparfinancial.DbType = System.Data.DbType.Int32;
           dbparfinancial.Direction = System.Data.ParameterDirection.Input;
           dbparfinancial.ParameterName = "@id";
           dbparfinancial.Value = idfinancialdet;
           command.Parameters.Add(dbparfinancial);

       }

       public override Financial_Details GetById(object id)
       {

          Financial_Details finD = base.GetById(id);

           return finD;
       }



    }
}
