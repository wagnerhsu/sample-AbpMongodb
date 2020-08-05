using AbpMongodb.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpMongodb.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpMongodbController : AbpController
    {
        protected AbpMongodbController()
        {
            LocalizationResource = typeof(AbpMongodbResource);
        }
    }
}