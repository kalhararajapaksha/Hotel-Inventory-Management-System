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
     [OperationContract]
     [WebInvoke(Method = "GET",
     UriTemplate = "LoadAllUsers",
     BodyStyle = WebMessageBodyStyle.Wrapped,
     RequestFormat = WebMessageFormat.Json,
     ResponseFormat = WebMessageFormat.Json)]
      string LoadAllUsers();


     [OperationContract]
     [WebInvoke(Method = "POST",
     UriTemplate = "SaveUser",
     BodyStyle = WebMessageBodyStyle.Wrapped,
     RequestFormat = WebMessageFormat.Json,
     ResponseFormat = WebMessageFormat.Json)]
     string SaveUser(REF_User oREF_User);

    [OperationContract]
    [WebInvoke(Method = "POST",
    UriTemplate = "UserLogin",
    BodyStyle = WebMessageBodyStyle.Wrapped,
    RequestFormat = WebMessageFormat.Json,
    ResponseFormat = WebMessageFormat.Json)]
    string GetUserByUserName(REF_User oREF_User);
    }
}
