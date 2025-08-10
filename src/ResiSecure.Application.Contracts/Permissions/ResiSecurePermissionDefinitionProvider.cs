using ResiSecure.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace ResiSecure.Permissions;

public class ResiSecurePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ResiSecurePermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(ResiSecurePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ResiSecureResource>(name);
    }
}
