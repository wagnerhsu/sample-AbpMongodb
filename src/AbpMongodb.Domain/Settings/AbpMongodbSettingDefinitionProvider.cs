using Volo.Abp.Settings;

namespace AbpMongodb.Settings
{
    public class AbpMongodbSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpMongodbSettings.MySetting1));
        }
    }
}
