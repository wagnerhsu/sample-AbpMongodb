using System.Threading.Tasks;

namespace AbpMongodb.Data
{
    public interface IAbpMongodbDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
