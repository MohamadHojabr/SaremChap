using System.Web.Http;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SaremChap.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(SaremChap.App_Start.NinjectWebCommon), "Stop")]

namespace SaremChap.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using DataLayer.Context;
    using ServiceLayer.Services;
    using ServiceLayer.EFServices;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            
            var kernel = new StandardKernel();
            GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(kernel);
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

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
            kernel.Bind<IUnitOfWork>().To<SaremChapContext>().InRequestScope();
            kernel.Bind<IChapterService>().To<EfChapterService>().InRequestScope();
            kernel.Bind<IFieldService>().To<EfFieldService>().InRequestScope();
            kernel.Bind<IFormService>().To<EfFormService>().InRequestScope();
            kernel.Bind<IGalleryItemService>().To<EfGalleryItemService>().InRequestScope();
            kernel.Bind<IGalleryService>().To<EfGalleryService>().InRequestScope();
            kernel.Bind<IOrderService>().To<EfOrderService>().InRequestScope();
            kernel.Bind<IPriceService>().To<EfPriceService>().InRequestScope();
            kernel.Bind<IProductCategoryService>().To<EfProductCategoryService>().InRequestScope();
            kernel.Bind<IProductService>().To<EfProductService>().InRequestScope();
            kernel.Bind<ISubjectService>().To<EfSubjectService>().InRequestScope();
            kernel.Bind<IValueService>().To<EfValueService>().InRequestScope();
        }        
    }
}
