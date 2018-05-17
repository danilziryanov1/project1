using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Mapping;

namespace DocFlow.ClassLibrary
{
    class CommentMap : ClassMap<Comment>
    {
        public CommentMap()
        {
            Id(c => c.Id);
            Map(c => c.CreationDate);
            Map(c => c.EditDate);
            References(c => c.Author);
            Map(c => c.Text).Length(500);
            HasMany(c => c.comments).Inverse().Cascade.All();
        }
    }
}
