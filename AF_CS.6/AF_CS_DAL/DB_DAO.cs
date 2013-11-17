﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using AF_CS_BO;



namespace AF_CS_DAL
{
    public abstract class DB_DAO<T> : ICrud<T>
    {

        //Queries / stored procedures
        protected string cmdInsert;
        protected string cmdUpdate;
        protected string cmdDelete;
        protected string cmdGetBy;
        protected string cmdGetAll;
        protected string cmdGetScore;



        // Affectation stored procedure parameters 
        protected abstract void IdToParameter(object id, NpgsqlCommand command);
        protected abstract T ReaderToObject(NpgsqlDataReader dr);
        protected abstract void ObjectToParameters(object id, T obj, NpgsqlCommand command);



        //DB Connexion
        NpgsqlConnection connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=cortex1;Database=AF;");
        //NpgsqlConnection connection2 = new NpgsqlConnection("Server=Heroku;Port=5432;User Id=ualjhvmdfkemaj;Password=k3-1_l_sG0cyAPJVMAYkFRn-bi;Database=df2q321g8tbfst;");
        //Open
        public NpgsqlConnection OpenDb()
        {
        //    bool n = connection.State.Equals("Open");
        //    if (n == false)
            {
                try
                {
                    //connection2.Open();
                    connection.Open();
                }

                catch (Exception exp)
                {
                    throw new Exception("Connection cannot be made");
                }
                return connection;
               
            }
           
        }

        //Close
        public void CloseDb()
        {
            try
            {
                connection.Close();
               
            }
            catch (Exception)
            {
                throw new Exception("There was a problem closing the connection");
            }
        }


        public virtual object  Insert(int i,T obj)
        { // Connection
            using (NpgsqlConnection connection = OpenDb())
            {
                NpgsqlCommand command = connection.CreateCommand();

                command.CommandText = cmdInsert;
                command.CommandType = System.Data.CommandType.Text;

                

                try
                { ObjectToParameters(i, obj, command);

                        int n = command.ExecuteNonQuery();
                        if (n != 1)
                        {

                            throw new Exception("Operation could not be made");
                        }   //output
                        else
                        {
                            int nbParam = command.Parameters.Count;
                            object ID = command.Parameters[nbParam - 1].Value;
                            return ID;
                        }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occured :\n" + ex.Message);
                }

               
            }
        }


        public virtual T GetById(object Id)
        {// Connection
              using (NpgsqlConnection connection = (OpenDb()))
            {
                NpgsqlCommand command = connection.CreateCommand();
                command.CommandText = cmdGetBy;
                command.CommandType = System.Data.CommandType.Text;
               

                
                // Parameter to stored proc
                IdToParameter(Id, command);
                T obj = default(T);
                try
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                obj = ReaderToObject(dr);
                            }
                            return obj;
                        }
                        else throw new Exception("Inexistant");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("This item could not be found , system :\n" + ex.Message);
                }
              

            }
        }

        public virtual T GetAll()
        {
             using (NpgsqlConnection connection = (OpenDb()))
            {
                NpgsqlCommand command = connection.CreateCommand();
                command.CommandText = cmdGetAll;
                command.CommandType = System.Data.CommandType.Text;
                
                T obj = default(T);
                try
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                obj = ReaderToObject(dr);
                            }
                            return obj;
                        }
                        else throw new Exception("Inexistant");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("This item could not be found , system :\n" + ex.Message);
                }
                
            }
        }

        public virtual void Insert(int i,IEnumerable<T> les)
        {
            using (NpgsqlConnection connection = OpenDb())
            {
                NpgsqlCommand command = connection.CreateCommand();
                command.CommandText = cmdInsert;
                foreach (T obj in les)
                {
                    try
                    {
                        ObjectToParameters(i, obj, command);

                        int n = command.ExecuteNonQuery();
                        if (n != 1)
                            throw new Exception("Operation could not be made");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occured: \n" + ex.Message);

                    }

                }
            }
        }

       
   public virtual T GetScores(object Id)        
   {  using (NpgsqlConnection connection = OpenDb())
            {
                NpgsqlCommand command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = cmdGetScore;
                // Parameter to stored proc
                IdToParameter(Id, command);
                T obj = default(T);
                try
                {
                    using (NpgsqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                obj = ReaderToObject(dr);
                            }
                            return obj;
                        }
                        else throw new Exception("Inexistant");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("This item could not be found , system :\n" + ex.Message);
                }
     
            }
        }
            }
   
        }

    

//        