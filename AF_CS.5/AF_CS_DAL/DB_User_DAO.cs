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
   public class DB_User_DAO :DB_DAO<User>
   {
    public DB_User_DAO()
        {
            cmdGetAll = "SELECT * FROM user";
            cmdGetBy = "SELECT * FROM users WHERE iduser = @id";
            cmdInsert = String.Empty;
            
        }
        protected override void ObjectToParameters(User obj, NpgsqlCommand command)
        {
            throw new NotImplementedException();
        }
        protected override User ReaderToObject(NpgsqlDataReader dr)
        {
           User thisuser = new User();
            thisuser.idUser = Convert.ToInt32(dr[0]);
            thisuser.username = Convert.ToString(dr[1]);
            thisuser.firstName = Convert.ToString(dr[2]);
            thisuser.lastName = Convert.ToString(dr[3]);
            return thisuser;

            
        }

        protected override void IdToParameter(object id, NpgsqlCommand command)
        {
            command.Parameters.Clear();
            int iduser = (int)id;
            NpgsqlParameter dbpar1 = command.CreateParameter();
            dbpar1.DbType = System.Data.DbType.Int32;
            dbpar1.Direction = System.Data.ParameterDirection.Input;
            dbpar1.ParameterName = "@iduser";
            dbpar1.Value = iduser;
            command.Parameters.Add(dbpar1);
        }

        public override User GetScores(object Id)
        {
            return base.GetScores(Id);
        }
    }
}
