﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storyteller.Models
{
    public class Adventure
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Premise Premise { get; set; }
        public ICollection<Tag> Tags { get; set; }

        public virtual ICollection<PC> PCs { get; set; }
        public virtual ICollection<NPC> NPCs { get; set; }
        public virtual ICollection<Enemy> Enemies { get; set; }
        public virtual ICollection<Artifact> Artifacts { get; set; }
        public virtual ICollection<Location> Locations { get; set; }

        public Hook Hook { get; set; }

        public CallToAdventure CallToAdventure { get; set; }

        public ICollection<Quest> FirstQuest { get; set; }

        public ICollection<VillainScene> VillainStrikesBack { get; set; }

        public ICollection<Quest> SecondQuest { get; set; }

        public ICollection<VillainScene> VillainsRevenge { get; set; }

        public ICollection<Quest> ThirdQuest { get; set; }

        public ICollection<VillainScene> DarknessBeforeDawn { get; set; }

        public FinalBattle FinalBattle { get; set; }

    }
}