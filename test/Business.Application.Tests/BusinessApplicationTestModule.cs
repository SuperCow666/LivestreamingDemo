using Volo.Abp.Modularity;

namespace Business
{
    [DependsOn(
        typeof(BusinessApplicationModule),
        typeof(BusinessDomainTestModule)
        )]
    public class BusinessApplicationTestModule : AbpModule
    {

    }
}