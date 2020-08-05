using AbpMongodb.MongoDB;
using Xunit;

namespace AbpMongodb
{
    [CollectionDefinition(AbpMongodbTestConsts.CollectionDefinitionName)]
    public class AbpMongodbDomainCollection : AbpMongodbMongoDbCollectionFixtureBase
    {

    }
}
