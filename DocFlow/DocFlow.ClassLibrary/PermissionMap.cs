using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Mapping;

namespace DocFlow.ClassLibrary
{
    class PermissionMap : ClassMap<Permission>
    {
        public PermissionMap()
        {
            Id(p => p.Id);
            Map(p => p.Description).Length(100);
            HasMany(p => p.userGroups).Inverse().Cascade.All();
            HasMany(p => p.folders).Inverse().Cascade.All();
        }
    }
}
