using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HRUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //注入容器
            var builder = new ContainerBuilder();
            //把当前程序集中的 Controller 都注册
            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();
            Assembly[] assemblies = new Assembly[] { Assembly.Load("HRBLL"), Assembly.Load("HRDAO") };
            builder.RegisterAssemblyTypes(assemblies)
            .AsImplementedInterfaces().PropertiesAutowired();
            var container = builder.Build();
            //注册系统级别的 DependencyResolver，这样当 MVC 框架创建 Controller 等对象的时候都是管 Autofac 要对象。
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));//!!!


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
