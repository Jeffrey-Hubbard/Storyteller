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
    public abstract class Scene
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public int LocationID { get; set; }
        public int EnemyID { get; set; }
        public ICollection<Clue> Clues { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public QuestType Type { get; set; }
    }
}