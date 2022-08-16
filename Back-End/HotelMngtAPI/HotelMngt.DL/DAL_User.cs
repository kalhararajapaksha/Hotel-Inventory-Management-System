using HotelMngt.REF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMngt.DL
{
    public class DAL_User
    {
        public DataTable SelectByUserNameAndPassword(REF_User oREF_User, DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_USER_SELECT_BY_USERNAME_AND_PASSWORD";

                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@UserName", oREF_User.UserName);
                oSqlCommand.Parameters.AddWithValue("@Password", oREF_User.Password);
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);
                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable LoadUsers(DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_USER_SELECT_ALL";
                oSqlCommand = new SqlCommand();
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LoadAllEmployee(DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_EMPLOYEE_GETALL";
                oSqlCommand = new SqlCommand();
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SaveUser(DB_Handle oDB_Handle, REF_User oREF_User)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_USER_ADD";
                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@UserID", oREF_User.UserID);
                oSqlCommand.Parameters.AddWithValue("@EmployeeID", oREF_User.EmployeeID);
                oSqlCommand.Parameters.AddWithValue("@UserName", oREF_User.UserName);
                oSqlCommand.Parameters.AddWithValue("@Password", oREF_User.Password);
                oSqlCommand.Parameters.AddWithValue("@CreateBy", oREF_User.CreateBy);
                oSqlCommand.Parameters.AddWithValue("@ModifyDate", oREF_User.ModifyDate);
                oSqlCommand.Parameters.AddWithValue("@ModifyBy", oREF_User.ModifyBy);
                oSqlCommand.Parameters.AddWithValue("@Satus", oREF_User.Satus);
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
