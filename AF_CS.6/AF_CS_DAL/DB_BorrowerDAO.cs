using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using AF_CS_BO;

namespace AF_CS_DAL
{
    public class DB_BorrowerDAO : DB_DAO<Borrower>
    {
        public DB_BorrowerDAO()
        {
            cmdGetAll = "SELECT * FROM borrower";
            cmdGetBy = "SELECT * FROM borrower WHERE @id = id";
            cmdInsert = String.Empty;
            
        }
        protected override void ObjectToParameters(object id, Borrower obj, NpgsqlCommand command)
        {
            throw new NotImplementedException();
        }
        protected override Borrower ReaderToObject(NpgsqlDataReader dr)
        {
            Borrower thisborrower = new Borrower();
            thisborrower.idBorrower = Convert.ToInt32(dr[0]);
            thisborrower.borrowerProfile = Convert.ToString(dr[4]);
            return thisborrower;

            
        }

        protected override void IdToParameter(object id, NpgsqlCommand command)
        {
            command.Parameters.Clear();
            int idborrower = (int)id;
            NpgsqlParameter dbpar1 = command.CreateParameter();
            dbpar1.DbType = System.Data.DbType.Int32;
            dbpar1.Direction = System.Data.ParameterDirection.Input;
            dbpar1.ParameterName = "@idborrower";
            dbpar1.Value = idborrower;
            command.Parameters.Add(dbpar1);
        }

        public override Borrower GetScores(object Id)
        {
            return base.GetScores(Id);
        }


    }
}
