using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;
using Npgsql;

namespace AF_CS_DAL
{
    public class DB_Credit_ScoreDAO : DB_DAO<Credit_Score>
    {
        public DB_Credit_ScoreDAO()
        {
            cmdGetAll = " SELECT *FROM creditscore";
            cmdGetBy = "SELECT * FROM creditscore WHERE @id =  iDcreditscore";
            cmdGetScore = "SELECT score FROM creditscore WHERE @id =iDcreditscore";
        }

        protected override void ObjectToParameters(Credit_Score obj, Npgsql.NpgsqlCommand command)
        {
            throw new NotImplementedException();
        }

        protected override Credit_Score ReaderToObject(Npgsql.NpgsqlDataReader dr)
        {
            try
            {
                Credit_Score thisCS = new Credit_Score();
                thisCS.iDcreditscore = Convert.ToInt32(dr[0]);
                thisCS.score = Convert.ToInt32(dr[1]);
                thisCS.grade = Convert.ToString(dr[2]);
                thisCS.comment = Convert.ToString(dr[3]);
                return thisCS;
            }
            catch 
            {
            throw new NotImplementedException();
            }
        }

        protected override void IdToParameter(object id, Npgsql.NpgsqlCommand command)
        {
            command.Parameters.Clear();
            int idcreditscore = (int)id;
            NpgsqlParameter dbparcs = command.CreateParameter();
            dbparcs.DbType = System.Data.DbType.Int32;
            dbparcs.Direction = System.Data.ParameterDirection.Input;
            dbparcs.ParameterName = "@iDcreditscore";
            dbparcs.Value = idcreditscore;
            command.Parameters.Add(dbparcs);
        }

        protected int GetScore(object id)
        {
            Credit_Score cScore = base.GetScores(id);
            return cScore.score;
        }
    }

}
