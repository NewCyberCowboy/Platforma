﻿namespace Platforma.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
