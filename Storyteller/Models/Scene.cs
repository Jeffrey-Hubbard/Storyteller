using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storyteller.Models
{
    public abstract class Scene
    {
        public int ID { get; set; }
        public Question Question { get; set; }
        public Location Location { get; set; }

    }
}