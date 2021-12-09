using Business.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Business.Permissions
{
    public class BusinessPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BusinessPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(BusinessPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BusinessResource>(name);
        }
    }
}
