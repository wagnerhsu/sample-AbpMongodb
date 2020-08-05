using AbpMongodb.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpMongodb.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpMongodbMongoDbModule),
        typeof(AbpMongodbApplicationContractsModule)
        )]
    public class AbpMongodbDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
