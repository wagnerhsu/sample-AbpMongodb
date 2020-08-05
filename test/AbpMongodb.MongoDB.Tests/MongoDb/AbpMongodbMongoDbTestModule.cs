using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace AbpMongodb.MongoDB
{
    [DependsOn(
        typeof(AbpMongodbTestBaseModule),
        typeof(AbpMongodbMongoDbModule)
        )]
    public class AbpMongodbMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionString = AbpMongodbMongoDbFixture.ConnectionString.EnsureEndsWith('/') +
                                   "Db_" +
                                   Guid.NewGuid().ToString("N");

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}
