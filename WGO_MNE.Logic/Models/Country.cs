using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGO_MNE.Logic.Models
{
    public class Country
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public byte[] Icon { get; private set; }

        public Country(int id, string name, byte[] icon)
        {
            Id = id;
            Name = name;
            Icon = icon;
        }

        public Country(string name, byte[] icon)
        {
            Name = name;
            Icon = icon;
        }
    }
}
