using HotelMngt.REF;
using HotemMngt.BL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HotelMngtAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {


        #region SELECT
        public string LoadAllExternalOrders()
        {
            try
            {
                BAL_Order oBAL_Order = new BAL_Order();


                DataTable dt;
                dt = oBAL_Order.LoadAllExternalOrders(null);
                Response oResponse = new Response();
                oResponse.Success = true;
                oResponse.oDataTable = dt;
                return JsonConvert.SerializeObject(oResponse);
            }
            catch (Exception ex)
            {
                Response oResponse = new Response();
                oResponse.Success = false;
                oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject("Error! Something went wrong. Please contact the system administrator.");
            }
        }
    
        public string LoadAllInternalOrders()
        {
            try
            {
                BAL_Order oBAL_Order = new BAL_Order();


                DataTable dt;
                dt = oBAL_Order.LoadAllInternalOrders(null);
                Response oResponse = new Response();
                oResponse.Success = true;
                oResponse.oDataTable = dt;
                return JsonConvert.SerializeObject(oResponse);
            }
            catch (Exception ex)
            {
                Response oResponse = new Response();
                oResponse.Success = false;
                oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject("Error! Something went wrong. Please contact the system administrator.");
            }
        }
        public string LoadAllCategory()
        {
            try
            {
                BAL_Category oBAL_Category = new BAL_Category();


                DataTable dt;
                dt = oBAL_Category.LoadAllCategory(null);
                Response oResponse = new Response();
                oResponse.Success = true;
                oResponse.oDataTable = dt;
                return JsonConvert.SerializeObject(oResponse);
            }
            catch (Exception ex)
            {
                Response oResponse = new Response();
                oResponse.Success = false;
                oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject("Error! Something went wrong. Please contact the system administrator.");
            }
        }
        public string LoadAllItem()
        {
            try
            {
                BAL_Stock oBAL_Stock = new BAL_Stock();


                DataTable dt;
                dt = oBAL_Stock.LoadAllItems( null);
                Response oResponse = new Response();
                oResponse.Success = true;
                oResponse.oDataTable = dt;
                return JsonConvert.SerializeObject(oResponse);
            }
            catch (Exception ex)
            {
                Response oResponse = new Response();
                oResponse.Success = false;
                oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject("Error! Something went wrong. Please contact the system administrator.");
            }
        }

        public string LoadAllSubCategory()
        {
            try
            {
                BAL_Category oBAL_Category = new BAL_Category();


                DataTable dt;
                dt = oBAL_Category.LoadAllSubCategory(null);
                Response oResponse = new Response();
                oResponse.Success = true;
                oResponse.oDataTable = dt;
                return JsonConvert.SerializeObject(oResponse);
            }
            catch (Exception ex)
            {
                Response oResponse = new Response();
                oResponse.Success = false;
                oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject("Error! Something went wrong. Please contact the system administrator.");
            }
        }

        public string LoadUnit()
        {
            try
            {
                BAL_Category oBAL_Category = new BAL_Category();


                DataTable dt;
                dt = oBAL_Category.LoadAllUnit(null);
                Response oResponse = new Response();
                oResponse.Success = true;
                oResponse.oDataTable = dt;
                return JsonConvert.SerializeObject(oResponse);
            }
            catch (Exception ex)
            {
                Response oResponse = new Response();
                oResponse.Success = false;
                oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject("Error! Something went wrong. Please contact the system administrator.");
            }
        }

        public string GetLowerItems()
        {
            try
            {
                BAL_Stock oBAL_Stock = new BAL_Stock();


                DataTable dt;
                dt = oBAL_Stock.GetLowStock(null);
                Response oResponse = new Response();
                oResponse.Success = true;
                oResponse.oDataTable = dt;
                return JsonConvert.SerializeObject(oResponse);
            }
            catch (Exception ex)
            {
                Response oResponse = new Response();
                oResponse.Success = false;
                oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject("Error! Something went wrong. Please contact the system administrator.");
            }
        }



        #endregion

        #region INSERT
        public string SaveStock(REF_Stock oREF_Stock)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region UPDATE
        public string ExternalOrders(REF_ExternalOrder oREF_ExternalOrder)
        {
            try
            {
                BAL_Order oBAL_Order = new BAL_Order();


                DataTable dt;
                dt = oBAL_Order.ExternalOrders(null, oREF_ExternalOrder);
                Response oResponse = new Response();
                oResponse.Success = true;
                oResponse.oDataTable = dt;
                return JsonConvert.SerializeObject(oResponse);
            }
            catch (Exception ex)
            {
                Response oResponse = new Response();
                oResponse.Success = false;
                oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject("Error! Something went wrong. Please contact the system administrator.");
            }
        }

        public string InternalOrders(REF_InternalOrders oREF_InternalOrders)
        {
            try
            {
                BAL_Order oBAL_Order = new BAL_Order();


                DataTable dt;
                dt = oBAL_Order.InternalOrders(null, oREF_InternalOrders);
                Response oResponse = new Response();
                oResponse.Success = true;
                oResponse.oDataTable = dt;
                return JsonConvert.SerializeObject(oResponse);
            }
            catch (Exception ex)
            {
                Response oResponse = new Response();
                oResponse.Success = false;
                oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject("Error! Something went wrong. Please contact the system administrator.");
            }
        }







        #endregion

        #region DELETE
        #endregion

    }
}
