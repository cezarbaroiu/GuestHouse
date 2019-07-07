using System.Web.Http;
using WebActivatorEx;
using GuestHouse.Web;
using Swashbuckle.Application;

namespace GuestHouse.Web
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "GuestHouse.Web");
                    })
                .EnableSwaggerUi();
        }
    }
}
