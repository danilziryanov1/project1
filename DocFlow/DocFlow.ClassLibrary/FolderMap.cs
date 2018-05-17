using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate;

namespace DocFlow.ClassLibrary
{
    class FolderMap : ClassMap<Folder>
    {
        public FolderMap()
        {
            Id(f => f.Id);
            Map(f => f.Name).Length(30);
            References(f => f.ParentFolder);
            Map(f => f.CreationDate);
            Map(f => f.CreationDate);
            References(f => f.Author);
            References(f => f.EditAuthor);
        }
    }
}
