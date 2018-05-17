using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Mapping;

namespace DocFlow.ClassLibrary
{
    class FileMap : ClassMap<File>
    {
        public FileMap()
        {
            Id(f => f.Id);
            Map(f => f.Name).Length(100);
            Map(f => f.Type).Length(20);
            Map(f => f.Size).Length(20);
        }
    }
}
