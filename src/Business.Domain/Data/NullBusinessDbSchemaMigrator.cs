using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Business.Data
{
    /* This is used if database provider does't define
     * IBusinessDbSchemaMigrator implementation.
     */
    public class NullBusinessDbSchemaMigrator : IBusinessDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}