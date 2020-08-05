using AbpMongodb.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpMongodb.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpMongodbPageModel : AbpPageModel
    {
        protected AbpMongodbPageModel()
        {
            LocalizationResourceType = typeof(AbpMongodbResource);
        }
    }
}