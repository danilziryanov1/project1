using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFlow.ClassLibrary
{
    class Document : Folder
    {
        public string Description { get; set; }
        public List<Version> VersionList { get; set; }
        public string DocumentType { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
