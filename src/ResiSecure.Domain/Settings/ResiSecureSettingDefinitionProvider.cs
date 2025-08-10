using Volo.Abp.Settings;

namespace ResiSecure.Settings;

public class ResiSecureSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ResiSecureSettings.MySetting1));
    }
}
