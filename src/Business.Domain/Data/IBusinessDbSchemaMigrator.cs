using System.Threading.Tasks;

namespace Business.Data
{
    public interface IBusinessDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
