using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Mapping;


namespace DocFlow.ClassLibrary
{
    class UserMap :ClassMap<User>
    {
        public UserMap()
        {
            Id (u=>u.Id);
            Map(u => u.Login).Length(30);
            Map(u => u.Password).Column("PasswordHash");
            Map(u => u.Name).Length(30);
            Map(u => u.Surname).Length(30);
            Map(u => u.Patronymic).Length(30);
            Map(u => u.Sol).Length(30);
            Map(u => u.Status);
            Map(u => u.Birthday);
        }
    }
}
