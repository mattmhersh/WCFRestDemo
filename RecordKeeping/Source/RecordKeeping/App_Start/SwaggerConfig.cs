using System.Web.Http;
using Rk.Manager;
using Swashbuckle.Application;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Rk.Manager
{
    public class SwaggerConfig
    {
        public static void Register()
        {            
            GlobalConfiguration.Configuration
                .EnableSwagger("api-docs/{apiVersion}/", c =>
                    {                        
                        c.Schemes(new[] { "http", "https" });
                        
                        c.SingleApiVersion("v1", "Ascensus Recordkeeping API")
                            .Description("An API for managing recordkeeping information at Ascensus")
                            .TermsOfService("Team White")
                            .Contact(cc => cc
                                .Name("Team White")
                                .Url("https://www.ascensus.com/Utility/ContactUs/index.htm")
                                .Email("api@ascensus.com"))
                            .License(lc => lc
                                .Name("License")
                                .Url("https://www.ascensus.com/Utility/TermsConditions/index.htm"));
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}