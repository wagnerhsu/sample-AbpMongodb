using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpMongodb.Data
{
    /* This is used if database provider does't define
     * IAbpMongodbDbSchemaMigrator implementation.
     */
    public class NullAbpMongodbDbSchemaMigrator : IAbpMongodbDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}