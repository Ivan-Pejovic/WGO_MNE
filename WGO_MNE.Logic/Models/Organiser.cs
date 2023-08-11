using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGO_MNE.Logic.Models
{
    public class Organiser
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Biography { get; private set; }
        public string Address { get; private set; }
        public byte[] ProfilePicture { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
