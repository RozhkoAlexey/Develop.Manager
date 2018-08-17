namespace Develop.Manager.App_Start
{
    using Autofac;
    using Autofac.Integration.Mvc;
    using Develop.Manager.Application;
    using System.Reflection;
    using System.Web.Mvc;

    internal static class IoCConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterModule<IoCModule>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}