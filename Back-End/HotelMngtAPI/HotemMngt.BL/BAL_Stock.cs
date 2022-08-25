using HotelMngt.DL;
using HotelMngt.REF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotemMngt.BL
{
    public class BAL_Stock
    {
        #region SELECT
        public DataTable LoadAllItems(DB_Handle oDB_Handle)
        {
            DAL_Stock oDAL_Stock = new DAL_Stock();
            DataTable oDataTable = new DataTable();
            DataTable _dt = null;

            try
            {
                bool newDBHandle = false;
                if (oDB_Handle == null)
                {
                    oDB_Handle = new DB_Handle();
                    oDB_Handle.OpenConnection();
                    oDB_Handle.BeginTransaction();
                    newDBHandle = true;
                }
                oDataTable = oDAL_Stock.LoadAllItems(oDB_Handle);
                if (newDBHandle)
                {
                    oDB_Handle.CommitTransaction();
                    oDB_Handle.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    oDB_Handle.RollbackTransaction();
                    oDB_Handle.CloseConnection();
                }
                catch (Exception)
                {
                    return _dt;
                }
            }
            return oDataTable;
        }

        public DataTable GetLowStock(DB_Handle oDB_Handle)
        {
            DAL_Stock oDAL_Stock = new DAL_Stock();
            DataTable oDataTable = new DataTable();
            DataTable _dt = null;

            try
            {
                bool newDBHandle = false;
                if (oDB_Handle == null)
                {
                    oDB_Handle = new DB_Handle();
                    oDB_Handle.OpenConnection();
                    oDB_Handle.BeginTransaction();
                    newDBHandle = true;
                }
                oDataTable = oDAL_Stock.GetLowStock(oDB_Handle);
                if (newDBHandle)
                {
                    oDB_Handle.CommitTransaction();
                    oDB_Handle.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    oDB_Handle.RollbackTransaction();
                    oDB_Handle.CloseConnection();
                }
                catch (Exception)
                {
                    return _dt;
                }
            }
            return oDataTable;
        }

        #endregion

        #region INSERT
        public DataTable SaveItem(DB_Handle oDB_Handle, REF_Stock oREF_Stock)
        {
            DAL_Stock oDAL_Stock = new DAL_Stock();
            DataTable oDataTable = new DataTable();
            DataTable _dt = null;

            try
            {
                bool newDBHandle = false;
                if (oDB_Handle == null)
                {
                    oDB_Handle = new DB_Handle();
                    oDB_Handle.OpenConnection();
                    oDB_Handle.BeginTransaction();
                    newDBHandle = true;
                }
                oDataTable = oDAL_Stock.SaveItem(oDB_Handle, oREF_Stock);
                if (newDBHandle)
                {
                    oDB_Handle.CommitTransaction();
                    oDB_Handle.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    oDB_Handle.RollbackTransaction();
                    oDB_Handle.CloseConnection();
                }
                catch (Exception)
                {
                    return _dt;
                }
            }
            return oDataTable;
        }
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion
    }
}
