using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using GuestHouse.Web.Routing;

namespace GuestHouse.Web.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            SwaggerConfig.Register(config);
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: RouteNames.GetRooms,
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
