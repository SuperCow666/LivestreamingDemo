using Volo.Abp.Settings;

namespace Business.Settings
{
    public class BusinessSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(BusinessSettings.MySetting1));
        }
    }
}
