using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Storyteller.Models;

namespace Storyteller.DAL
{
    public class StorytellerInitializer : System.Data.Entity.DropCreateDatabaseAlways<StorytellerContext>
    {
        protected override void Seed(StorytellerContext context)
        {


            var artifacts = new List<Artifact>
            {
                new Artifact {Name="Sunsword", Description="A longsword whose blade is made of pure, bright energy.", Type="Sword"},
                new Artifact {Name="The Stone Which Abides", Description = "A luminescent green stone the size of a small watermelon.", Powers="Unknown"}
            };

            artifacts.ForEach(a => context.Artifacts.Add(a));
            context.SaveChanges();

            var PCs = new List<PC>
            {
                new PC {Name="Sleegoth", Class="Warrior", Level=9, Race="Human"},
                new PC {Name="Karl", Class="Thief", Level=7, Race="Orc"},
                new PC {Name="Lundrec Brighthelm", Race="Human", Class="Rogue"}
            };

            PCs.ForEach(c => context.PCs.Add(c));
            context.SaveChanges();

            var Enemies = new List<Enemy>
            {
                new Enemy {Name="Yap Klortho", Title="Baron", Race="Human", EnemyType=EnemyType.Archenemy},
                new Enemy {Name="Ragefist", Race="Abomination", EnemyType=EnemyType.Henchman},
                new Enemy {Name="Vardy", Class="Death Knight", EnemyType=EnemyType.Henchman, Race="Tiefling"},
                new Enemy {Name="Goblin Warrior", Race="Goblin", Class="Warrior", EnemyType=EnemyType.Minion},
                new Enemy {Name="Goblin Archer", Race="Goblin", Class="Archer", EnemyType=EnemyType.Minion},
                new Enemy {Name="Swamp Monster", Race="Abomination", EnemyType=EnemyType.Minion},
                new Enemy {Name="Klorn Hosk", Race="Fire Giant", Title="King", Class="Warrior", EnemyType=EnemyType.Social},
                new Enemy {Name="Wildfire Ridge", EnemyType=EnemyType.Environment},
                new Enemy {Name="NakNak", Race="Goblin", EnemyType=EnemyType.Social, Title="Insurgent"},
                new Enemy {Name="Cavern Collapse", EnemyType=EnemyType.Environment}
            };

            Enemies.ForEach(e => context.Enemies.Add(e));
            context.SaveChanges();

            var locations = new List<Location>
            {
                new Location {Name="The Caverns of Woe", Description="Underdark caverns half-filled with water and the mournful wails of the souls of the drowned.", Effects="Each morning, DC: 12 Wis Save or suffer 1 level of exhaustion from poor sleep, bad dreams, troubled thoughts."},
                new Location {Name="Briarthorn", Description="A quiet farming town, the patron family of which is known for horsemanship."},
                new Location {Name="Blightbarrow", Description="A fetid, shallow swamp where an old graveyard used to lie."},
                new Location {Name="Briarthorne Manor", Description="The manorhouse of the eponymous local noble family."},
                new Location {Name="The Yellow Moors", Description="Rolling plains of yellow wheat and tall grass."},
                new Location {Name="Vance Prison and Asylum", Description="An old noble manor converted to a combination asylum and prison for dangerous criminals."},
                new Location {Name="Wornarrow Shipping Warehouse", Description="A warehouse on the waterfront of Briarthorn, dark and seemingly abandoned."}
            };

            locations.ForEach(l => context.Locations.Add(l));
            context.SaveChanges();

            var questions = new List<Question>
            {
                new Premise { Need="Keep the town from deserting", EnemyID=4, WhatsAtStake="Support from Briarthorne family in upcoming war."},
                new Question { Need="Find the shaman.", WhatsAtStake="Learning the weakness of the villian."},
                new Question { Need="Meet the shaman in town", WhatsAtStake="Learning the danger to the village."},
                new Question { Need="Rescue the shaman before he is killed or gives up the secret."},
                new Question { Need="Give chase to the kidnappers and try to take back the shaman by force."},
                new Question { Need="Convince the insurgent to give them aid and information on the goblins."}
            };

            questions.ForEach(q => context.Questions.Add(q));
            context.SaveChanges();

            var clues = new List<Clue>
            {
                new Clue {Description="A letter to the enemy from an unnamed author that references", HowToFind="DC:12 Investigation" },
                new Clue {Description="A signet ring of an old noble house.", HowToFind="Simple search"},
                new Clue {Description="A map leading to", HowToFind="Simple search"},
                new Clue {Description="Coded, hand-written message.", HowToFind="DC:10 Knowledge to decode"},
                new Clue {Description="Box of supplies labled with shipping company name.", HowToFind="DC:12 Perception"},
                new Clue {Description="A rough drawing of the nearby town.", HowToFind="Simple search"}

            };

            clues.ForEach(c => context.Clues.Add(c));
            context.SaveChanges();

            var scenes = new List<Scene>
            {
                new Hook { LocationID=2, QuestionID=3, EnemyID=2 },
                new CallToAdventure {LocationID=4, QuestionID=2, EnemyID=4 },
                new Quest {LocationID=3, Type=QuestType.combat, EnemyID=9, QuestionID=5 },
                new Quest {LocationID=3, Type=QuestType.environmental, EnemyID=13, QuestionID=5 },
                new Quest {LocationID=7, Type=QuestType.social, EnemyID=12, QuestionID=6 },
                new VillainScene {LocationID=2, Type=QuestType.combat, EnemyID=4, QuestionID=6},
                new VillainScene {LocationID=2, Type=QuestType.puzzle, EnemyID=4, QuestionID=6},
                new Quest {LocationID=2, Type=QuestType.combat, EnemyID=5, QuestionID=6},
                new VillainScene {LocationID=2, Type=QuestType.combat, EnemyID=6, QuestionID=6},
                new VillainScene {LocationID=2, Type=QuestType.social, EnemyID=10, QuestionID=6},
                new Quest {LocationID=2, Type=QuestType.combat, EnemyID=7, QuestionID=6},
                new VillainScene {LocationID=2, Type=QuestType.combat, EnemyID=8, QuestionID=6},
                new VillainScene {LocationID=2, Type=QuestType.social, EnemyID=7, QuestionID=6},
                new FinalBattle {LocationID=2, Type=QuestType.combat, EnemyID=4, QuestionID=6}

            };

            scenes.ForEach(s => context.Scenes.Add(s));
            context.SaveChanges();

            //var adventure = new Adventure
            //{
            //    Name = "The Swamps of Briarthorn",
            //    Premise = questions[0] as Premise,
            //    Hook = scenes[0] as Hook,
            //    CallToAdventure = scenes[1] as CallToAdventure,
            //    FirstQuest = {scenes[2] as Quest, scenes[3] as Quest, scenes[4] as Quest},
            //    VillainStrikesBack = { scenes[5] as VillainScene, scenes[6] as VillainScene},
            //    SecondQuest = { scenes[2] as Quest, scenes[3] as Quest, scenes[4] as Quest, scenes[7] as Quest },
            //    VillainsRevenge = { scenes[8] as VillainScene, scenes[9] as VillainScene },
            //    ThirdQuest = { scenes[2] as Quest, scenes[3] as Quest, scenes[4] as Quest, scenes[7] as Quest, scenes[10] as Quest },
            //    DarknessBeforeDawn = { scenes[11] as VillainScene, scenes[12] as VillainScene },
            //    FinalBattle = scenes[13] as FinalBattle
            //};

            //for (int x = 0; x < 3; x++)
            //{
            //    adventure.PCs.Add(PCs[x]);
            //}
            //for (int x = 0; x < 9; x++)
            //{
            //    adventure.Enemies.Add(Enemies[x]);
            //}
            //for (int x = 0; x < 2; x++)
            //{
            //    adventure.Artifacts.Add(artifacts[x]);
            //}
            //for (int x = 0; x < 7; x++)
            //{
            //    adventure.Locations.Add(locations[x]);
            //}

            //context.Adventures.Add(adventure);
            //context.SaveChanges();

            base.Seed(context);
        }


    }
}