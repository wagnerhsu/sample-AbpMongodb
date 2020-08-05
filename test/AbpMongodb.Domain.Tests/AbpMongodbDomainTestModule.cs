using AbpMongodb.MongoDB;
using Volo.Abp.Modularity;

namespace AbpMongodb
{
    [DependsOn(
        typeof(AbpMongodbMongoDbTestModule)
        )]
    public class AbpMongodbDomainTestModule : AbpModule
    {

    }
}