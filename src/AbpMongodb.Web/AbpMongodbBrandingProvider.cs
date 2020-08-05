using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace AbpMongodb.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpMongodbBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpMongodb";
    }
}
