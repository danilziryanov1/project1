using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFlow.ClassLibrary
{
    public class Folder
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Folder ParentFolder { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditDate { get; set; }
        public User Author { get; set; }
        public User EditAuthor { get; set; }
        private string route;
        private Folder folder;
        public string GetRoute()
        {
            while (ParentFolder != null)
            {
                route = ParentFolder.Name + "/" + route;
                folder = ParentFolder;
                ParentFolder = folder.ParentFolder;
            }
            return route;
        }
    }
}
