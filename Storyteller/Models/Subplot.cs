using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storyteller.Models
{
    public class Subplot
    {
        public int ID { get; set; }
        public Character Character { get; set; }
        public string Need { get; set; }
        public Artifact Artifact { get; set; }
        public Enemy Enemy { get; set; }
        public NPC Friend { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}