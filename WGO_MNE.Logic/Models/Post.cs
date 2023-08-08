using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGO_MNE.Logic.Models
{
    public class Post
    {
        public int Id { get; private set; }
        public User Author { get; private set; }
        public string Text { get; private set; }
        public string Location { get; private set; }
        public DateTime DateCreated { get; private set; }
        public List<string> Photos { get; private set; }
    }
}
