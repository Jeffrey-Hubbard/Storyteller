using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Storyteller.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Storyteller.DAL
{
    public class StorytellerContext : DbContext
    {
        public StorytellerContext() : base("StorytellerContext")
        {
            Database.SetInitializer<StorytellerContext>(new DropCreateDatabaseAlways<StorytellerContext>());
        }

        public DbSet<Adventure> Adventures { get; set; }
        public DbSet<Artifact> Artifacts { get; set; }
        public DbSet<PC> PCs { get; set; }
        public DbSet<NPC> NPCs { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Clue> Clues { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Scene> Scenes { get; set; }
        public DbSet<Subplot> Subplots { get; set; }
        public DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Question>()
                .Map<Premise>(m => m.Requires("Discriminator").HasValue("Premise"));

            modelBuilder.Entity<Scene>()
                .Map<Hook>(m => m.Requires("Discriminator").HasValue("Hook"))
                .Map<CallToAdventure>(m => m.Requires("Discriminator").HasValue("CallToAdventure"))
                .Map<Quest>(m => m.Requires("Discriminator").HasValue("Quest"))
                .Map<VillainScene>(m => m.Requires("Discriminator").HasValue("VillainScene"))
                .Map<FinalBattle>(m => m.Requires("Discriminator").HasValue("FinalBattle"));
        }

    }
}