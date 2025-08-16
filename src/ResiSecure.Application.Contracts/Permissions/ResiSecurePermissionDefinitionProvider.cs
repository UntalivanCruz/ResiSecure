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
        
        var propertiesPermission = myGroup.AddPermission(ResiSecurePermissions.Properties.Default, L("Permission:Properties"));
        propertiesPermission.AddChild(ResiSecurePermissions.Properties.Create, L("Permission:Properties.Create"));
        propertiesPermission.AddChild(ResiSecurePermissions.Properties.Edit, L("Permission:Properties.Edit"));
        propertiesPermission.AddChild(ResiSecurePermissions.Properties.Delete, L("Permission:Properties.Delete"));
        
        var householdsPermission = myGroup.AddPermission(ResiSecurePermissions.Households.Default, L("Permission:Households"));
        householdsPermission.AddChild(ResiSecurePermissions.Households.Create, L("Permission:Households.Create"));
        householdsPermission.AddChild(ResiSecurePermissions.Households.Edit, L("Permission:Households.Edit"));
        householdsPermission.AddChild(ResiSecurePermissions.Households.Delete, L("Permission:Households.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ResiSecureResource>(name);
    }
}
