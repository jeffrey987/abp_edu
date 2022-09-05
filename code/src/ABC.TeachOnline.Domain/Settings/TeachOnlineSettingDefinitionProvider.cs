using Volo.Abp.Settings;

namespace ABC.TeachOnline.Settings
{
    public class TeachOnlineSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TeachOnlineSettings.MySetting1));
        }
    }
}
