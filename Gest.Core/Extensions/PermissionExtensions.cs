using Gest.Core.Entities;

namespace Gest.Core.Extensions
{
    public static class PermissionExtensions
    {
        public static User SetPermissionToSection(this User user, string permission, string section, bool isAdding = true)
        {
            var currentPermissions = user.Permissions;
            if (string.IsNullOrEmpty(permission) || string.IsNullOrEmpty(section))
            {
                user.Permissions = currentPermissions;
                return user;
            }

            if(string.IsNullOrEmpty(currentPermissions))
            {
                if (!isAdding)
                {
                    user.Permissions = currentPermissions;
                    return user;
                }
                user.Permissions = $"{section}:[{permission}]";
                return user;
            }

            var getSection = currentPermissions.Split(';').SingleOrDefault(x => x.Contains(section));
            if(string.IsNullOrEmpty(getSection))
            {
                if (!isAdding)
                {
                    user.Permissions = currentPermissions;
                    return user;
                }
                user.Permissions =  $"{currentPermissions};{section}:[{permission}]";
                return user;
            }

            var permissions = getSection.Split(':').Last();
            var existingPermission = permissions.Split(',').SingleOrDefault(x => x == permission);
            if(string.IsNullOrEmpty(existingPermission))
            {
                if (!isAdding)
                {
                    user.Permissions = currentPermissions;
                    return user;
                }
                var newPermission = $"{section}:{permissions},{permission}";
                user.Permissions = currentPermissions.Replace($";{getSection}", $";{newPermission}");
                return user;
            }

            if (isAdding)
            {
                user.Permissions = currentPermissions;
                return user;
            }

            var removedPermission = $"{section}:{permissions.Replace($",{permission}", "")}";

            user.Permissions = currentPermissions.Replace($";{getSection}", $";{removedPermission}");
            return user;
            
        }

        public static User GiveAllPermissions(this User user)
        {
            var userPermission = string.Empty;
            foreach(var section in AppSections.All())
            {
                if (string.IsNullOrEmpty(userPermission))
                    userPermission = $"{section}";
                else
                    userPermission = $"{userPermission};{section}";

                var permissions = string.Empty;
                foreach (var permission in AppPermissions.All())
                {
                    if (string.IsNullOrEmpty(permissions))
                        permissions = $"{permission}";
                    else
                        permissions = $"{permissions},{permission}";
                }

                userPermission = $"{userPermission}:{permissions}";
            }
            user.Permissions =  userPermission;
            return user;
        }

        public static User RemoveAllPermissions(this User user)
        {
            user.Permissions = string.Empty;
            return user;
        }

        public static Dictionary<string,List<PermissionCheck>> GetPermissions(this User? user)
        {

            var permChecks = new Dictionary<string, List<PermissionCheck>>();
            if (user is null)
                return permChecks;

            var allSections = user.Permissions.Split(';');

            foreach (var section in AppSections.All())
            {
                var allPermissions = new List<PermissionCheck>();
                var currentPermissions = allSections.FirstOrDefault(x => x.Contains(section))?.Split(':').LastOrDefault();
                foreach (var item in AppPermissions.All())
                {
                    allPermissions.Add(new PermissionCheck() { IsChecked = currentPermissions?.Contains(item) ?? false, Permission = item });
                }
                permChecks.Add(section, allPermissions);
            }
            return permChecks;
        }

        public static Dictionary<string, List<PermissionCheck>> GetAllPermissions(this User? user)
        {
            var permChecks = new Dictionary<string, List<PermissionCheck>>();

            foreach (var section in AppSections.All())
            {
                var allPermissions = new List<PermissionCheck>();
                foreach (var item in AppPermissions.All())
                {
                    allPermissions.Add(new PermissionCheck() { IsChecked = false, Permission = item });
                }
                permChecks.Add(section, allPermissions);
            }

            return permChecks;
        }
    
        public static string ToStringPermissions(this Dictionary<string, List<PermissionCheck>> permissions)
        {
            if(permissions is { Count: > 0 })
            {
                var permissionString = "";
                foreach(var item in permissions)
                {
                    if(item.Value.Any(x => x.IsChecked))
                    {
                        if (string.IsNullOrEmpty(permissionString))
                            permissionString = $"{item.Key}:";
                        else
                            permissionString += $";{item.Key}:";
                    }
                    foreach(var value in item.Value.Where(x => x.IsChecked))
                    {
                        if (permissionString.Last() == ':')
                            permissionString += $"{value.Permission}";
                        else
                            permissionString += $",{value.Permission}";
                    }
                }
                return permissionString;
            }
            return string.Empty;
        }
    }
}
