using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel.Activation;
using Swaggerator.Attributes;

namespace Rk.Manager
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [Swaggerated("/PlanManager", "Everything about your 401k Plan")]
    public class PlanManager : IPlanManager
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

        [Description("Delete Plan")]
        public Plan DeletePlan(string id)
        {
            return new Plan { Name = "Plan Deleted", Id = Convert.ToInt32(id) };
        }

        [Description("Load Plan")]
        public LoadedPlan LoadPlan(IPlanLoadRequest planRequest)
        {
            return new LoadedPlan {
                LoadMessage = "Success", 
                Plan = new GeneralPlanInfo
                {
                    Name = planRequest.GenPlanIDSys
                }};
        }

        [Description("Add Plan")]
        public Plan AddPlan(IPlan plan)
        {
            return new Plan { Name = "Plan Added", Id = plan.Id };
        }

        [Description("Update Plan")]
        public Plan UpdatePlan(IPlan plan)
        {
            return new Plan { Name = plan.Name, Id = plan.Id };
        }
    }
}