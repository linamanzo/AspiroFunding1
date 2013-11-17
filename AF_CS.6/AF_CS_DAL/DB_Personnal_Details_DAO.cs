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
   public  class DB_Personnal_Details_DAO : DB_DAO<Personnal_Details>
    {public DB_Personnal_Details_DAO()
       {
          
            cmdGetAll = "SELECT * FROM personnaldetails";
            cmdGetBy = "SELECT * FROM personnaldetails WHERE  iduser = @id";
            cmdGetScore = "GETPERSCORE";
          
            
        }
    public DB_Personnal_Details_DAO(Personnal_Details obj)
    {  cmdInsert = "INSERT INTO creditscore (personnalscore)" + "(values (@pscore))";
    }
    protected override void ObjectToParameters(object id, Personnal_Details obj, NpgsqlCommand command)
    {
        NpgsqlParameter pscore = command.CreateParameter();
       pscore.DbType = System.Data.DbType.Int32;
        pscore.Direction = System.Data.ParameterDirection.Input;
        pscore.ParameterName = "@pscore";
         
        pscore.Value =  obj.personnalScore;
        command.Parameters.Add(pscore);
    }
        protected override Personnal_Details ReaderToObject(NpgsqlDataReader dr)
        {
            Personnal_Details thispersd = new Personnal_Details();
            thispersd.iDpersD = Convert.ToInt32(dr[0]);
            thispersd.age = Convert.ToInt32(dr[1]);
            thispersd.maritalStatus = Convert.ToString(dr[2]);
            thispersd.residentialStatus = Convert.ToString(dr[3]);
            thispersd.personnalScore = Convert.ToInt32(dr[4]);
            thispersd.idcreditscore = Convert.ToInt32(dr[5]);
            return thispersd;

            
        }

        protected override void IdToParameter(object id, NpgsqlCommand command)
        {
            command.Parameters.Clear();
            int idpersdet = (int)id;
            NpgsqlParameter dbpar1 = command.CreateParameter();
            dbpar1.DbType = System.Data.DbType.Int32;
            dbpar1.Direction = System.Data.ParameterDirection.Input;
            dbpar1.ParameterName = "@id";
            dbpar1.Value = idpersdet;
            command.Parameters.Add(dbpar1);
        }

         public override Personnal_Details GetById(object id)
        {
          
            Personnal_Details persd = base.GetById(id);

            return persd;
        }

       
    }
}
