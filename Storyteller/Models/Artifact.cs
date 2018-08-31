using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storyteller.Models
{
    public class Artifact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Character Owner { get; set; }
        public string Description { get; set; }
        public string Powers { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}