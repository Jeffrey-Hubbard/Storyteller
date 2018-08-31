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

        }

        public DbSet<Adventure> Adventures { get; set; }
        public DbSet<Artifact> Artifacts { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Clue> Clues { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Scene> Scenes { get; set; }
        public DbSet<Subplot> Subplots { get; set; }
        public DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .Map<PC>(m => m.Requires("Discriminator").HasValue("PC"))
                .Map<NPC>(m => m.Requires("Discriminator").HasValue("NPC"))
                .Map<Enemy>(m => m.Requires("Discriminator").HasValue("Enemy"));

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