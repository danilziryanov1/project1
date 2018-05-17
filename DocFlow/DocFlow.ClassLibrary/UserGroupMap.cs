using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate;

namespace DocFlow.ClassLibrary
{
    class UserGroupMap : ClassMap<UserGroup>
    {
        public UserGroupMap()
        {
            Id( u=> u.Id);
            Map(u => u.Name).Length(50);
            References(u => u.Photo);
            Map(u => u.Description).Length(100);
            HasMany(u => u.Users).Inverse().Cascade.All();
        }
    }
}
