using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Storyteller.Models;

namespace Storyteller.DAL
{
    public class StorytellerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StorytellerContext>
    {
        protected override void Seed(StorytellerContext context)
        {
            var adventure = new Adventure
            {
                Name = "The Cries of the Drowned",
                Premise = new Premise { Need = "To keep the down from deserting.", Opposition = new Enemy { FirstName = "Yap", LastName = "Klortho", Title = "Baron", Class = "Necromancer" }, WhatsAtStake = "Resources from House Briarthorne in the Southern Wars." }
            };

            //var artifacts = new List<Artifact>
            //{
            //    new Artifact {Name="Sunsword", Description="A longsword whose blade is made of pure, bright energy.", Type="Sword"},
            //    new Artifact {Name="The Stone Which Abides", Description = "A luminescent green stone the size of a small watermelon.", Powers="Unknown"}
            //};

            //artifacts.ForEach(a => context.Artifacts.Add(a));
            //context.SaveChanges();

            //var characters = new List<Character>
            //{
            //    new PC {FirstName = "Sleegoth", LastName = "HisLastName", Class="Warrior", Level=9, Race="Human"},
            //    new PC {FirstName = "Karl", LastName="Karlson", Class="Thief", Level=7, Race="Orc"},
            //    new PC {FirstName = "Lundrec", LastName="Brighthelm", Race="Human", Class="Rogue"},
            //    new Enemy {FirstName="Yap", Title="Baron", LastName="Klortho", Race="Human", EnemyType=EnemyType.Archenemy},
            //    new Enemy {FirstName="Ragefist", Race="Abomination", EnemyType=EnemyType.Henchman}
            //};

            //characters.ForEach(c => context.Characters.Add(c));
            //context.SaveChanges();

            //var locations = new List<Location>
            //{
            //    new Location {Name="The Caverns of Woe", Description="Underdark caverns half-filled with water and the mournful wails of the souls of the drowned.", Effects="Each morning, DC: 12 Wis Save or suffer 1 level of exhaustion from poor sleep, bad dreams, troubled thoughts."},
            //    new Location {Name="Briarthorn", Description="A quiet farming town, the patron family of which is known for horsemanship."}
            //};

            //locations.ForEach(l => context.Locations.Add(l));
            //context.SaveChanges();

            //var questions = new List<Question>
            //{
            //    new Question { Need="Keep the town from deserting", Opposition="Necromancer", WhatsAtStake="Support from Briarthorne family in upcoming war."}
            //};

            //var scenes = new List<Scene>
            //{
                

            //};
        }
    }
}