using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using cero.EntityFrameworkCore;

namespace cero.Web.Host
{
    [DependsOn(typeof(ceroApplicationModule), typeof(ceroEntityFrameworkCoreModule), typeof(AbpAspNetCoreModule))]
    public class ceroWebHostModule : AbpModule
    {
        public override void PreInitialize()
        {
            // Expose all AppServices as dynamic API controllers
            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(ceroApplicationModule).GetAssembly(),
                    moduleName: "app",
                    useConventionalHttpVerbs: true
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ceroWebHostModule).GetAssembly());
        }
    }
}
