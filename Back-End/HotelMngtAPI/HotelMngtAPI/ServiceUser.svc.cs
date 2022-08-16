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
using System.Web;

namespace HotelMngtAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceUser" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceUser.svc or ServiceUser.svc.cs at the Solution Explorer and start debugging.
    public class ServiceUser : IServiceUser
    {
        public string GetUserByUserName(REF_User oREF_User)
        {
            try
            {
                BAL_User oBAL_User = new BAL_User();


                DataTable dt;
                dt = oBAL_User.SelectByUserNameAndPassword(oREF_User, null);
              //  Response oResponse = new Response();
               // oResponse.Success = true;
                //oResponse.oDataTable = dt;
                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
               // Response oResponse = new Response();
              //  oResponse.Success = false;
               // oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject("Error! Something went wrong. Please contact the system administrator.");
            }
        }
        public string LoadAllEmployee()
        {
            DataTable dt = new DataTable();
            try
            {
                BAL_User oBAL_User = new BAL_User();

                dt = oBAL_User.LoadAllEmployee(null);


                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string LoadAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                BAL_User oBAL_User = new BAL_User();

                dt = oBAL_User.LoadUser(null);

                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string SaveUser(REF_User oREF_User)
        {
            DataTable dt = new DataTable();
            try
            {
                BAL_User oBAL_User = new BAL_User();                        
                dt = oBAL_User.SaveUser(null, oREF_User);

                Response oResponse = new Response();
                oResponse.Success = true;
                oResponse.Message = "Success!";
                return JsonConvert.SerializeObject(oResponse);

                
            }
            catch (Exception ex)
            {
                Response oResponse = new Response();
                oResponse.Success = false;
                oResponse.Message = "Error! Something went wrong. Please contact the system administrator. (" + ex.Message + ")";
                return JsonConvert.SerializeObject(oResponse);
            }
        }
        //Hello
    }
}
