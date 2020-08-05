using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpMongodb.Pages
{
    [Collection(AbpMongodbTestConsts.CollectionDefinitionName)]
    public class Index_Tests : AbpMongodbWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
