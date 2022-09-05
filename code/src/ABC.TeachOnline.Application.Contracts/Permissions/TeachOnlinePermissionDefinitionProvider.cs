using ABC.TeachOnline.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABC.TeachOnline.Permissions
{
    public class TeachOnlinePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TeachOnlinePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(TeachOnlinePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TeachOnlineResource>(name);
        }
    }
}
