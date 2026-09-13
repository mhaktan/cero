using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace cero
{
    [DependsOn(typeof(ceroCoreModule), typeof(AbpAutoMapperModule))]
    public class ceroApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                cfg.AddMaps(typeof(ceroApplicationModule).GetAssembly());
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ceroApplicationModule).GetAssembly());
        }
    }
}
