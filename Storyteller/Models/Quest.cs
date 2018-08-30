using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storyteller.Models
{
    public enum QuestType
    {
        combat, social, environmental, puzzle
    }
    public class Quest : Scene
    {
        public QuestType Type { get; set; }
    }
}