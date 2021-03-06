[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SiprolimarApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(SiprolimarApi.App_Start.NinjectWebCommon), "Stop")]

namespace SiprolimarApi.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using System.Web.Http;
    using WebApiContrib.IoC.Ninject;
    using SiprolimarApi.DAL;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                //dependency injection
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(kernel);

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IRol>().To<DALRol>();
            kernel.Bind<IUsuario>().To<DALUsuario>();
            kernel.Bind<ITamannoProducto>().To<DALTamannoProducto>();
            kernel.Bind<IProducto>().To<DALProducto>();
            kernel.Bind<ITipoFactura>().To<DALTipoFactura>();
            kernel.Bind<IFactura>().To<DALFactura>();
            kernel.Bind<ITipoTelefono>().To<DALTipoTelefono>();
            kernel.Bind<ICliente>().To<DALCliente>();
            kernel.Bind<ICliente_TipoTelefono>().To<DALCliente_TipoTelefono>();
            kernel.Bind<ILineaFactura>().To<DALLineaFactura>();
        }        
    }
}
