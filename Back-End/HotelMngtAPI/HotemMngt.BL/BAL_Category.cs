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
    public class BAL_Category
    {
        #region SELECT


        public DataTable LoadAllCategory(DB_Handle oDB_Handle)
        {
            DAL_Category oDAL_Category = new DAL_Category();
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
                oDataTable = oDAL_Category.LoadAllCategory(oDB_Handle);
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

        public DataTable LoadAllSubCategory(DB_Handle oDB_Handle)
        {
            DAL_Category oDAL_Category = new DAL_Category();
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
                oDataTable = oDAL_Category.LoadAllSubCategory(oDB_Handle);
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

        public DataTable LoadAllUnit(DB_Handle oDB_Handle)
        {
            DAL_Category oDAL_Category = new DAL_Category();
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
                oDataTable = oDAL_Category.LoadAllUnit(oDB_Handle);
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
        
        #endregion

        #region DELETE
        #endregion
    }
}
