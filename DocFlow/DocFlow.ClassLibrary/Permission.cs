using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFlow.ClassLibrary
{
    class Permission
    {
        public long Id { get; set; }
        public List<UserGroup> userGroups { get; set; }
        public List<Folder> folders { get; set; }
        public string Description { get; set; }
    }
}
