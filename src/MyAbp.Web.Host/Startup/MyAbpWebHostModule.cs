using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbp.Configuration;

using Microsoft.AspNetCore.Cors;

namespace MyAbp.Web.Host.Startup
{
    [DependsOn(
       typeof(MyAbpWebCoreModule))]
    public class MyAbpWebHostModule: AbpModule
    {
        [System.Obsolete]
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        [System.Obsolete]
        public MyAbpWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpWebHostModule).GetAssembly());
            ////var cors = new EnableCorsAttribute("*", "*", "*");
            //var cors = new EnableCorsAttribute("*");
            ////cors.SupportsCredentials = true;
            //GlobalConfiguration.Configuration.EnableCors(cors);
        }
    }
}
