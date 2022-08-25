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
    public class BAL_Order
    {
        #region SELECT
        public DataTable LoadAllInternalOrders(DB_Handle oDB_Handle)
        {
            DAL_Order oDAL_Order = new DAL_Order();
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
                oDataTable = oDAL_Order.LoadAllInternalOrders(oDB_Handle);
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

        public DataTable LoadAllExternalOrders(DB_Handle oDB_Handle)
        {
            DAL_Order oDAL_Order = new DAL_Order();
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
                oDataTable = oDAL_Order.LoadAllExternalOrders(oDB_Handle);
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
        #endregion

        #region UPDATE
        public DataTable InternalOrders(DB_Handle oDB_Handle, REF_InternalOrders oREF_InternalOrders)
        {
            DAL_Order oDAL_Order = new DAL_Order();
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
                oDataTable = oDAL_Order.InternalOrders(oDB_Handle, oREF_InternalOrders);
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
        public DataTable ExternalOrders(DB_Handle oDB_Handle, REF_ExternalOrder oREF_ExternalOrder)
        {
            DAL_Order oDAL_Order = new DAL_Order();
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
                oDataTable = oDAL_Order.ExternalOrders(oDB_Handle, oREF_ExternalOrder);
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

        #region DELETE
        #endregion
    }
}
