﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMngt.REF
{
    public class DB_Handle
    {
        private SqlConnection dbCon;
        private SqlTransaction dbTrans;


        private void CreateConnection()
        {
            string dbConString = @"Data Source=LAPTOP-69OEQGO0\SQLEXPRESS01;Initial Catalog=HOTEL_DB;Integrated Security=True";
            //string dbConString = @"Data Source=.\SQLEXPRESS; Initial Catalog=HOTEL_DB;User ID=sa;Password=SLATS@123;Max Pool Size=1000; MultipleActiveResultSets=True;Integrated Security=True";
            //string dbConString = @"Data Source=GEETHAN-LAP\SQLEXPRESS;Initial Catalog=HOTEL_DB;Integrated Security=True";
            Console.WriteLine(dbConString);
            dbCon = new SqlConnection(dbConString);

        }

        public void OpenConnection()
        {
            if (dbCon == null)
            {
                CreateConnection();
            }
            if (dbCon.State == ConnectionState.Closed)
            {
                dbCon.Open();
            }
        }

        public void CloseConnection()
        {
            if (dbCon.State != ConnectionState.Closed)
            {
                dbCon.Close();
            }

        }

        public void BeginTransaction()
        {
            dbTrans = dbCon.BeginTransaction();
        }

        public void CommitTransaction()
        {
            dbTrans.Commit();

        }

        public void RollbackTransaction()
        {
            if (dbTrans != null)
            {
                dbTrans.Rollback();
            }
        }

        public SqlConnection GetConnection()
        {
            return dbCon;
        }

        public SqlTransaction GetTransaction()
        {
            return dbTrans;
        }

        public void CloseDB()
        {
            if (GetConnection().State == ConnectionState.Open)
            {
                GetConnection().Dispose();
            }
        }
    }
}

