using System;
using System.Collections.Generic;
using System.Text;
using AbpMongodb.Localization;
using Volo.Abp.Application.Services;

namespace AbpMongodb
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpMongodbAppService : ApplicationService
    {
        protected AbpMongodbAppService()
        {
            LocalizationResource = typeof(AbpMongodbResource);
        }
    }
}
