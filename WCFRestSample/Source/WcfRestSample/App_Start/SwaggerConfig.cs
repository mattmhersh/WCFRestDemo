using System.Runtime.Remoting.Channels;
using System.Web;
using System.Web.Http;
using WcfRestSample;
using Swashbuckle.Application;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WcfRestSample
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            var myCustomBasePath = "http://localhost:53215/api-docs";

            GlobalConfiguration.Configuration
                .EnableSwagger("api-docs/{apiVersion}/", c =>
                    {
                        //c.RootUrl(req => "http://localhost:53215/swagger/api-docs");

                        c.Schemes(new[] { "http", "https" });

                        //c.IncludeXmlComments(@"C:\develop\github\WCFRestDemo\WCFRestSample\Source\WcfRestSample\bin\WcfRestSample.XML");

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
                        //c.EnableDiscoveryUrlSelector();
                        //c.DisableValidator();
                    });
        }
    }
}