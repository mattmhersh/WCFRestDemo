using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Swaggerator.Attributes;

namespace WcfRestSample
{
    [ServiceContract]
    public interface IBookService
    {
        //[OperationContract]
        //[WebGet]
        //List<Book> GetBooksList();

        [OperationContract]
        [WebGet(UriTemplate = "Plan/{id}", ResponseFormat = WebMessageFormat.Json)]
        Plan GetPlanById(string id);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "AddBook/{name}")]
        //void AddBook(string name);

        //[WebInvoke(Method = "POST",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Bare)]
        //void Add(RequestData Book);

        [OperationContract]
        [WebInvoke(UriTemplate = "UpdateBook/{id}/{name}")]
        void UpdateBook(string id, string name);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "DeleteBook/{id}")]
        //void DeleteBook(string id);

        [OperationContract]        
        //[OperationSummary("Example for hiding parameters and overriding return type")]
        //[OperationNotes("Two parameters, AsynchCallback callback and object asyncState are hidden")]
        [WebGet(UriTemplate = "/GetBooksNames", ResponseFormat = WebMessageFormat.Json)]
        //[WebGet(ResponseFormat=WebMessageFormat.Json)]
        List<string> GetBooksNames();
    }

    //[DataContract]
    //public class RequestData
    //{
    //    [DataMember]
    //    public string Name { get; set; }
    //}
}
