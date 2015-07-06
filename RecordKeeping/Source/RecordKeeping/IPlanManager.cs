using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using Swaggerator.Attributes;

namespace Rk.Manager
{
    /// <summary>
    /// Plan
    /// </summary>
    [ServiceContract]
    public interface IPlanManager
    {
        /// <summary>
        /// Get Plan Names
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [OperationSummary("Get Plan Names")]
        [OperationNotes("Returns Plan Names")]
        List<string> GetPlanNames();


        /// <summary>
        /// Get Plan By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        [OperationSummary("Get Plan By Id")]
        [OperationNotes("Returns a Plan")]
        //[WebGet(UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json)]
        Plan GetPlanById(string id);

        /// <summary>
        /// Add Plan
        /// </summary>
        /// <param name="plan"></param>
        [OperationContract]
        [ResponseCode(200, "OK")]
        [OperationSummary("Add Plan")]
        //[WebInvoke(UriTemplate = "AddPlan",
        //    Method = "POST",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Bare)]
        Plan AddPlan(IPlan plan);

        /// <summary>
        /// Update Plan
        /// </summary>
        /// <param name="plan"></param>
        /// <returns></returns>
        [OperationContract]
        [OperationSummary("Update Plan")]
        //[WebInvoke(UriTemplate = "UpdatePlan",
        //    Method = "PUT",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Bare)]
        Plan UpdatePlan(IPlan plan);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        [OperationSummary("Delete Plan")]
        //[WebInvoke(UriTemplate = "DeletePlan/{id}",
        //    Method = "DELETE",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Bare)]
        Plan DeletePlan(string id);  
    }
}
