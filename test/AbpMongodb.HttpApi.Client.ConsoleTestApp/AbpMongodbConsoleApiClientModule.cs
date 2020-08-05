using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpMongodb.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpMongodbHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpMongodbConsoleApiClientModule : AbpModule
    {
        
    }
}
