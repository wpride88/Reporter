using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Reporter1
{
    // Примечание: Инструкции по включению классического режима IIS6 или IIS7 
    // см. по ссылке http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Этот маршрут, названный DefaultDetails, применяется при получении запроса 
            //с адресованным любому контроллеру URL-адресом, заканчивающимся на /Details 
            //(следовательно, без идентификатора). Маршрут преобразует URL-адрес в класс 
            //ProductController и устанавливает Index в качестве действия, что приведет к  
            //генерации стандартного списка записей товаров. 

            //routes.MapRoute(
            //    "Default",
            //    "{controller}/{action}, id = UrlParameter.Optional",
            //    new { controller = "jobs", action = "Index", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    "DefaultDetails",
            //    "{controller}/Details",
            //    new { controller = "jobs", action = "Index", id = UrlParameter.Optional }
            //); 

            routes.MapRoute(
                "Default", // Имя маршрута
                "{controller}/{action}/{id}", // URL-адрес с параметрами
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Параметры по умолчанию
                //new { controller = "jobs", action = "Index", id = UrlParameter.Optional } // Параметры по умолчанию
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }
    }
}