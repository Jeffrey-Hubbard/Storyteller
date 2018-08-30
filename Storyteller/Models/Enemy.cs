using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storyteller.Models
{
    public enum EnemyType
    {
        Archenemy, Villain, Henchman, Minion
    }
    public class Enemy : Character
    {
        public EnemyType EnemyType { get; set; }
    }
}