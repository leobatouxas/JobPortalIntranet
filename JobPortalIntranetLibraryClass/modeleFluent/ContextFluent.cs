using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalIntranetLibraryClass.modeleFluent
{
    public class ContextFluent : DbContext
    {
        public ContextFluent() : base("name=Cours1ConnexionString2")
        {
            Database.SetInitializer<ContextFluent>(new DropCreateDatabaseIfModelChanges<ContextFluent>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            //modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Configurations.Add(new StatutFluent());
            modelBuilder.Configurations.Add(new OfferFluent());
            modelBuilder.Configurations.Add(new CandidacyFluent());
            modelBuilder.Configurations.Add(new EmployeFluent());
            modelBuilder.Configurations.Add(new ExperienceFluent());
            modelBuilder.Configurations.Add(new TrainingFluent());
        }

        public DbSet<Statut> Statuts { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Candidacy> Candidacies { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Training> Trainings { get; set; }

    }
}
