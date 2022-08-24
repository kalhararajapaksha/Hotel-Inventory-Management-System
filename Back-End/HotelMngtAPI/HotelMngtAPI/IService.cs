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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        #region SELECT
        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "LoadAllItem",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string LoadAllItem();

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "LoadAllCategory",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string LoadAllCategory();

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "LoadAllSubCategory",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string LoadAllSubCategory();

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "LoadUnit",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string LoadUnit();

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "LoadAllInternalOrders",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string LoadAllInternalOrders();

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "LoadAllExternalOrders",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string LoadAllExternalOrders();


        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "GetLowerItems",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string GetLowerItems();
        #endregion

        #region INSERT
        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "SaveStock",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string SaveStock(REF_Stock oREF_Stock);

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "InternalOrders",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string InternalOrders(REF_InternalOrders oREF_InternalOrders);

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "ExternalOrders",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string ExternalOrders(REF_ExternalOrder oREF_ExternalOrder);
        #endregion

        #region UPDATE

        #endregion

        #region DELETE
        #endregion

    }
}
