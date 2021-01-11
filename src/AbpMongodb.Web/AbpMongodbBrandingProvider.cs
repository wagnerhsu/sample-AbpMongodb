using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpMongodb.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpMongodbBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpMongodb";
    }
}