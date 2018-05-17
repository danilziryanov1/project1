using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFlow.ClassLibrary
{
    class UserGroup
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public File Photo { get; set; }
        public List<User> Users { get; set; }
    }
}
