using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storyteller.Models
{
    public class PC : Character
    {
        public int Level { get; set; }

        public ICollection<Artifact> Artifacts { get; set; }
        public ICollection<Subplot> Subplots { get; set; }

    }
}