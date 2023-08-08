using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGO_MNE.Logic.Models
{
    public class Post
    {
        public int Id { get; set; }
        public User Author { get; set; }
        public string Text { get; set; }
        public string Location { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
