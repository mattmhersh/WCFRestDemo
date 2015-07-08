using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Swaggerator.Attributes;

namespace Rk.Manager
{
    [ServiceContract]
    public interface IPlanManager
    {
        [OperationContract]
        [OperationSummary("Get Plan Names")]
        [OperationNotes("Returns Plan Names")]
        [ResponseCode(200, "Success")]
        List<string> GetPlanNames();

        [OperationContract]
        [OperationSummary("Get Plan By Id")]
        [OperationNotes("Returns a Plan")]
        [ResponseCode(200, "Success")]
        [ResponseCode(400, "Invalid ID supplied")]
        [ResponseCode(404, "Plan not found")]
        [ResponseCode(405, "Validation exception")]
        Plan GetPlanById(string id);

        [OperationContract]
        [ResponseCode(200, "OK")]
        [OperationSummary("Add Plan")]
        Plan AddPlan(IPlan plan);

        [OperationContract]
        [OperationSummary("Update Plan")]
        Plan UpdatePlan(IPlan plan);

        [OperationContract]
        [OperationSummary("Delete Plan")]
        Plan DeletePlan(string id);

        [OperationContract]
        [OperationSummary("Load Plan")]
        LoadedPlan LoadPlan(IPlanLoadRequest planRequest);  
    }

    public class LoadedPlan
    {
        public GeneralPlanInfo Plan { get; set; }

        public string LoadMessage { get; set; }
    }
    
    [DataContract]
    public class GeneralPlanInfo
    {
        [DataMember]
        public string Name { get; set;  }
    }

    [DataContract]
    public class IPlanLoadRequest
    {
        [DataMember]
        public string GenPlanIDSys { get; set; }
    }
}
