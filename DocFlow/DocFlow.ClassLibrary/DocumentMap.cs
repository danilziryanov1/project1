using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Mapping;

namespace DocFlow.ClassLibrary
{
    class DocumentMap : SubclassMap<Document>
    {
        public DocumentMap()
        {
            Map(d => d.Description).Length(200);
            HasMany(d => d.VersionList).Inverse().Cascade.All();
            Map(d => d.DocumentType).Length(20);
            HasMany(d => d.Comments).Inverse().Cascade.All();
        }
    }
}
