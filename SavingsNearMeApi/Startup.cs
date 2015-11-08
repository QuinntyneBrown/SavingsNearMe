using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Unity.WebApi;

[assembly: OwinStartup(typeof(SavingsNearMeApi.Startup))]

namespace SavingsNearMeApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(SavingsNearMeApi.UnityConfiguration.GetContainer());

            GlobalConfiguration.Configure(config => SavingsNearMeApi.ApiConfiguration.Install(config, app));
        }    
    }
}
