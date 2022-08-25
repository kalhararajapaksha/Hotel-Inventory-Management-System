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
    public class DAL_Stock
    {
        #region SELECT
        public DataTable LoadAllItems(DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_STOCK_GET_ALL";
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

        public DataTable GetLowStock(DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_ITEMS_SELECT_lOWER_ITEMS";
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

        #endregion

        #region INSERT
        public DataTable SaveItem(DB_Handle oDB_Handle, REF_Stock oREF_Stock)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_STOCK_SAVE";
                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@Item_ID", oREF_Stock.Item_ID);
                oSqlCommand.Parameters.AddWithValue("@Sub_CategoryID", oREF_Stock.Sub_CategoryID);
                oSqlCommand.Parameters.AddWithValue("@QTY", oREF_Stock.QTY);
                oSqlCommand.Parameters.AddWithValue("@UpdateBy", oREF_Stock.UpdateBy);
                oSqlCommand.Parameters.AddWithValue("@ItemName", oREF_Stock.ItemName);

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

        #region UPDATE
        #endregion

        #region DELETE
        #endregion
    }
}
