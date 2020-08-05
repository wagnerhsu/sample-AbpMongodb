using Volo.Abp.Modularity;

namespace AbpMongodb
{
    [DependsOn(
        typeof(AbpMongodbApplicationModule),
        typeof(AbpMongodbDomainTestModule)
        )]
    public class AbpMongodbApplicationTestModule : AbpModule
    {

    }
}