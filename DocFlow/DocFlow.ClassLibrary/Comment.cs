using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFlow.ClassLibrary
{
    class Comment
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditDate { get; set; }
        public User Author { get; set; }
        public string Text { get; set; }
        public List<Comment> comments { get; set; }
    }
}
