using HotelMngt.REF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HotelMngtAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceUser" in both code and config file together.
    [ServiceContract]
    public interface IServiceUser
    {
      
        #region SELECT
        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "LoadAllUsers",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string LoadAllUsers();

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "UserGetByID",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string UserGetByID(REF_User oREF_User);

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "LoadAllEmployee",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string LoadAllEmployee();

        #endregion

        #region INSERT
        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "SaveUser",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string SaveUser(REF_User oREF_User);
        #endregion

        #region UPDATE
        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "UpdateUser",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string UpdateUser(REF_User oREF_User);

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "DeleteUser",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string DeleteUser(REF_User oREF_User);
        #endregion

        #region AUTH
        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "UserLogin",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string GetUserByUserName(REF_User oREF_User);
        #endregion




    }
}
