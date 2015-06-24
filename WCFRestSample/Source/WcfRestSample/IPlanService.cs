using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using Swaggerator.Attributes;

namespace WcfRestSample
{
    [ServiceContract]
    public interface IPlanService
    {

        [OperationContract]
        [OperationSummary("Get Plan By Id")]
        [OperationNotes("Returns a Plan")]
        [WebGet(UriTemplate = "Plan/{id}", ResponseFormat = WebMessageFormat.Json)]
        Plan GetPlanById(string id);

        [OperationContract]
        [OperationSummary("Get Plan Names")]
        [OperationNotes("Returns Plan Names")]
        [WebGet(UriTemplate = "GetPlanNames", ResponseFormat = WebMessageFormat.Json)]
        List<string> GetPlanNames();

        [OperationContract]
        [OperationSummary("Update Plan")]
        [WebGet(UriTemplate = "UpdatePlan/{id}/{name}")]
        void UpdatePlan(string id, string name);

        [OperationContract]
        [OperationSummary("Delete Plan")]
        [WebGet(UriTemplate = "DeletePlan/{id}")]
        void DeletePlan(string id);

        [OperationContract]
        [OperationSummary("Add Plan")]
        [WebGet(UriTemplate = "AddPlan/{name}")]
        void AddPlan(string name);

        [OperationContract]
        [OperationSummary("Add Plan")]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        void Add(RequestData Plan);               
    }

    [DataContract]
    public class RequestData
    {
        [DataMember]
        public string Name { get; set; }
    }
}
