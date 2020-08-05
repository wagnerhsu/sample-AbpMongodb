using System.Threading.Tasks;
using AbpMongodb.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpMongodb
{
    /* Inherit your application services from this class.
     */
    public interface IAbpMongodbAppService : IApplicationService
    {
        Task TestAsync();
    }
}
