using System.Threading.Tasks;
using AbpMongodb.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpMongodb.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpMongodbController : AbpController
    {
        readonly IAbpMongodbAppService abpMongodbAppService;


        protected AbpMongodbController()
        {
            LocalizationResource = typeof(AbpMongodbResource);
        }

        public async Task<IActionResult> TestAsync()
        {
            await abpMongodbAppService.TestAsync();

            return Content("ok");
        }
    }
}