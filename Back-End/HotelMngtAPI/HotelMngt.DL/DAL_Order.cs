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
    public class DAL_Order
    {
        #region SELECT
        public DataTable LoadAllInternalOrders(DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_INTERNAL_ORDERS_GET_PENDING_APPROVE";
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

        public DataTable LoadAllExternalOrders(DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_EXTERNAL_ORDER_GET_PENDING_APPROVE";
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
        //SP_EXTERNAL_ORDER_GET_PENDING_APPROVE
        #endregion

        #region INSERT
        #endregion

        #region UPDATE
        public DataTable InternalOrders(DB_Handle oDB_Handle, REF_InternalOrders oREF_InternalOrders)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_ORDER_INTERNAL";
                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@OrderID", oREF_InternalOrders.OrderID);
                oSqlCommand.Parameters.AddWithValue("@ItemID", oREF_InternalOrders.ItemID);
                oSqlCommand.Parameters.AddWithValue("@Req_QTY", oREF_InternalOrders.Req_QTY);
                oSqlCommand.Parameters.AddWithValue("@OrderBy", oREF_InternalOrders.OrderBy);
                oSqlCommand.Parameters.AddWithValue("@ApprovedBy", oREF_InternalOrders.ApprovedBy);
                oSqlCommand.Parameters.AddWithValue("@IssuedBy", oREF_InternalOrders.IssuedBy);
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

        public DataTable ExternalOrders(DB_Handle oDB_Handle, REF_ExternalOrder oREF_ExternalOrder)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_ORDER_EXTERNAL";
                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@OrderID", oREF_ExternalOrder.OrderID);
                oSqlCommand.Parameters.AddWithValue("@ItemID", oREF_ExternalOrder.ItemID);
                oSqlCommand.Parameters.AddWithValue("@Req_QTY", oREF_ExternalOrder.Req_QTY);
                oSqlCommand.Parameters.AddWithValue("@PricePerUnit", oREF_ExternalOrder.PricePerUnit);
                oSqlCommand.Parameters.AddWithValue("@OrderBy", oREF_ExternalOrder.OrderBy);
                oSqlCommand.Parameters.AddWithValue("@ApprovedBy", oREF_ExternalOrder.ApprovedBy);
                oSqlCommand.Parameters.AddWithValue("@RecivedBy", oREF_ExternalOrder.RecivedBy);
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
        #endregion

        #region DELETE
        #endregion
    }
}
