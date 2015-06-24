using System.Collections.Generic;
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
        [WebGet(UriTemplate = "/GetPlanNames", ResponseFormat = WebMessageFormat.Json)]
        List<string> GetPlanNames();

        //[OperationContract]
        //[WebInvoke(UriTemplate = "UpdateBook/{id}/{name}")]
        //void UpdateBook(string id, string name);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "DeleteBook/{id}")]
        //void DeleteBook(string id);        

        //[OperationContract]
        //[WebInvoke(UriTemplate = "AddBook/{name}")]
        //void AddBook(string name);

        //[WebInvoke(Method = "POST",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Bare)]
        //void Add(RequestData Book);        
    }

    //[DataContract]
    //public class RequestData
    //{
    //    [DataMember]
    //    public string Name { get; set; }
    //}
}
