using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGO_MNE.Logic.Models
{
    public class Event
    {
        public int Id { get; private set; }
        public Organiser Organiser { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public float Price { get; private set; }
        public string Location { get; private set; }
        public List<byte[]> EventPictures { get; private set; }
        public List<Tag> Tags { get; private set; }
        public List<City> Citys { get; private set; }
        public List<Language> Languages { get; private set; }
    }
}
