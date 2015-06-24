using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel.Activation;
using Swaggerator.Attributes;

namespace WcfRestSample
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [Swaggerated("/PlanService.svc", "A RESTful WCF Service: Plan Services")]
    public class PlanService : IPlanService
    {
        [Description("Get Plan Names")]
        public List<string> GetPlanNames()
        {
            var books = new List<Plan> { 
                new Plan { Name = "Plan A" }, 
                new Plan { Name = "Plan B" } };
            return books.Select(plan => plan.Name).ToList();
        }

        [Description("Get Plan By ID")]
        public Plan GetPlanById(string id)
        {
            return new Plan { Name = "Plan Name A", Id = Convert.ToInt32(id) };
        }

        [Description("Update Plan")]
        public void UpdatePlan(string id, string name)
        {
            
        }

        [Description("Delete Plan")]
        public void DeletePlan(string id)
        {
         
        }

        [Description("Add Plan")]
        public void AddPlan(string name)
        {            
        }

        public void Add(RequestData Plan)
        {
            
        }
    }
}