[assembly: WebActivator.PostApplicationStartMethod(typeof(OAuthAspNetWebApiRest.Api.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace OAuthAspNetWebApiRest.Api.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using Domain.Contracts.Repostiories;
    using Data.Repositories;
    using Data;
    using Microsoft.AspNet.Identity;
    using Domain.Models;
    using Domain.Services;
    using Domain.Contracts.Services;
    using SimpleInjector.Lifestyles;
    using Domain.Contracts.Repositories;

    public static class SimpleInjectorWebApiInitializer
    {
        public static Container Container;
        static SimpleInjectorWebApiInitializer()
        {
            Container = new Container();
        }
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {

            Container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            InitializeContainer(Container);

            Container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            Container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(Container);
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<AppDbContext, AppDbContext>(Lifestyle.Scoped);
            //container.Register<DbContext>(container.GetInstance<AppContext>);
            container.Register<IUserStore<User>, AppUserStore>(Lifestyle.Scoped);
            container.Register<IUserRepository, UserRepository>(Lifestyle.Scoped);
            container.Register<IUserService, UserService>(Lifestyle.Scoped);
            container.Register<IProductRepository, ProductRepository>(Lifestyle.Scoped);
            container.Register<IProductService, ProductService>(Lifestyle.Scoped);
        }
    }
}