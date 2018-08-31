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

            var artifacts = new List<Artifact>
            {
                new Artifact {Name="Sunsword", Description="A longsword whose blade is made of pure, bright energy.", Type="Sword"},
                new Artifact {Name="The Stone Which Abides", Description = "A luminescent green stone the size of a small watermelon.", Powers="Unknown"}
            };

            artifacts.ForEach(a => context.Artifacts.Add(a));
            context.SaveChanges();

            var characters = new List<Character>
            {
                new PC {Name="Sleegoth", Class="Warrior", Level=9, Race="Human"},
                new PC {Name="Karl", Class="Thief", Level=7, Race="Orc"},
                new PC {Name="Lundrec Brighthelm", Race="Human", Class="Rogue"},
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

            characters.ForEach(c => context.Characters.Add(c));
            context.SaveChanges();

            var clues = new List<Clue>
            {
                new Clue {Description="A letter to the enemy from an unnamed author that references", HowToFind="DC:12 Investigation", SceneID=11 },
                new Clue {Description="A signet ring of an old noble house.", HowToFind="Simple search"},
                new Clue {Description="A map leading to", HowToFind="Simple search", SceneID=3},
                new Clue {Description="Coded, hand-written message.", HowToFind="DC:10 Knowledge to decode", SceneID=4},
                new Clue {Description="Box of supplies labled with shipping company name.", HowToFind="DC:12 Perception", SceneID=5},
                new Clue {Description="A rough drawing of the nearby town.", HowToFind="Simple search", SceneID=8}

            };

            clues.ForEach(c => context.Clues.Add(c));
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

            var scenes = new List<Scene>
            {
                new Hook { LocationID=2, QuestionID=3 },
                new CallToAdventure {LocationID=4, QuestionID=2, Clues={clues[3], clues[4], clues[5] }, EnemyID=4 },
                new Quest {LocationID=3, Type=QuestType.combat, EnemyID=9, QuestionID=5, Clues={clues[4], clues[5], clues[6] } },
                new Quest {LocationID=3, Type=QuestType.environmental, EnemyID=13, QuestionID=5, Clues={ clues[3], clues[5], clues[6]} },
                new Quest {LocationID=7, Type=QuestType.social, EnemyID=12, QuestionID=6, Clues={ clues[3], clues[5], clues[6]} },
                new VillainScene {LocationID=2, Type=QuestType.combat, EnemyID=4},
                new VillainScene {LocationID=2, Type=QuestType.puzzle, EnemyID=4},
                new Quest {Type=QuestType.combat, EnemyID=5},
                new VillainScene {Type=QuestType.combat, EnemyID=6},
                new VillainScene {Type=QuestType.social, EnemyID=10},
                new Quest {Type=QuestType.combat, EnemyID=7},
                new VillainScene {Type=QuestType.combat, EnemyID=8},
                new VillainScene {Type=QuestType.social, EnemyID=},
                new FinalBattle {Type=QuestType.combat, EnemyID=4}

            };

            scenes.ForEach(s => context.Scenes.Add(s));
            context.SaveChanges();
        }
    }
}