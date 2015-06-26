using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using Swaggerator.Attributes;

namespace WcfRestSample
{
    /// <summary>
    /// Plan
    /// </summary>
    [ServiceContract]
    public interface IPlanService
    {

        /// <summary>
        /// Get Plan By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        [OperationSummary("Get Plan By Id")]
        [OperationNotes("Returns a Plan")]
        [WebGet(UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json)]
        Plan GetPlanById(string id);

        /// <summary>
        /// Get Plan Names
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [OperationSummary("Get Plan Names")]
        [OperationNotes("Returns Plan Names")]
        [WebGet(UriTemplate = "GetPlanNames", ResponseFormat = WebMessageFormat.Json)]
        List<string> GetPlanNames();

        //[OperationContract]
        //[OperationSummary("Update Plan")]
        //[WebGet(UriTemplate = "UpdatePlan/{id}/{name}")]
        //void UpdatePlan(string id, string name);

        //[OperationContract]
        //[OperationSummary("Delete Plan")]
        //[WebGet(UriTemplate = "DeletePlan/{id}")]
        //void DeletePlan(string id);

        /// <summary>
        /// Add Plan
        /// </summary>
        /// <param name="plan"></param>
        [OperationContract]
        [ResponseCode(200, "OK")]
        [OperationSummary("Add Plan")]
        [WebInvoke(UriTemplate = "Add",
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        void AddPlan(IPlan plan);

        /// <summary>
        /// Update Plan
        /// </summary>
        /// <param name="plan"></param>
        /// <returns></returns>
        [OperationContract]
        [OperationSummary("Update Plan")]
        [WebInvoke(UriTemplate = "Update",
            Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        Plan UpdatePlan(IPlan plan);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        [OperationSummary("Delete Plan")]
        [WebInvoke(UriTemplate = "Delete/{id}",
            Method = "DELETE",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        Plan DeletePlan(string id);  
    }
}
