using Business.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Business
{
    [DependsOn(
        typeof(BusinessEntityFrameworkCoreTestModule)
        )]
    public class BusinessDomainTestModule : AbpModule
    {

    }
}