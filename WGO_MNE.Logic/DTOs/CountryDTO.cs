﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGO_MNE.Logic.DTOs
{
    public class CountryDTO
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Icon { get; private set; }
    
        public CountryDTO(int id, string name, string icon
            )
        {
            Id = id;
            Name = name;
            Icon = icon;
        }

        public CountryDTO(string name, string icon)
        {
            Name = name;
            Icon = icon;
        }
    }
}
