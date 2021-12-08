using Business.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Business.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BusinessEntityFrameworkCoreModule),
        typeof(BusinessApplicationContractsModule)
        )]
    public class BusinessDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
