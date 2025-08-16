namespace ResiSecure.Permissions;

public static class ResiSecurePermissions
{
    public const string GroupName = "ResiSecure";

    
    
    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    
    public static class Properties
    {
        public const string Default = GroupName + ".Properties";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
    
    public static class Households
    {
        public const string Default = GroupName + ".Households";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
