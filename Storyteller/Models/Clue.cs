using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storyteller.Models
{
    public class Clue
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string HowToFind { get; set; }
        public int SceneID { get; set; }
    }
}