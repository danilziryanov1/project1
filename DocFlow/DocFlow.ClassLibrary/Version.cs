using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFlow.ClassLibrary
{
    class Version
    {
        long Id { get; set; }
        File VersionFile { get; set; }
        long VersionNumber { get; set; }
        Document DocumentVersion { get; set; }
        DateTime CreationDate { get; set; }
        DateTime EditDate { get; set; }
        User AuthorCreate { get; set; }
        User Authoredit { get; set; }
        Enum Status { get; set; }
    }
}
