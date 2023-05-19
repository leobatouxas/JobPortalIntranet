using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortalIntranetLibraryClass.modeleFluent
{
    public class Employe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Firstname{ get; set; }

        [Required]
        public string Lastname { get; set; }

        public DateTime Dateofbirth { get; set; }

        public int Seniority { get; set; }
        public string Biography { get; set; }
        public ICollection<Candidacy> Candidacies { get; set; }

        public ICollection<Experience> Experiences { get; set; }

        public ICollection<Training> Trainings { get; set; }
    }

    public class EmployeFluent : EntityTypeConfiguration<Employe>
    {
        public EmployeFluent()
        {
            ToTable("APP_EMPLOYE");
            HasKey(cc => cc.Id);

            Property(cc => cc.Id).HasColumnName("TRA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(cc => cc.Firstname).HasColumnName("TRA_FIRSTNAME").IsRequired();
            Property(cc => cc.Lastname).HasColumnName("TRA_LASTNAME").IsRequired();
            Property(cc => cc.Dateofbirth).HasColumnName("TRA_DATEOFBIRTH");
            Property(cc => cc.Seniority).HasColumnName("TRA_SENIORITY");
            Property(cc => cc.Biography).HasColumnName("TRA_BIOGRAPHY");

            HasMany(cc => cc.Candidacies).WithRequired(c => c.Employe).HasForeignKey(c => c.EmployeId);
            HasMany(cc => cc.Experiences).WithRequired(c => c.Employe).HasForeignKey(c => c.EmployeId);
            HasMany(cc => cc.Trainings).WithRequired(c => c.Employe).HasForeignKey(c => c.EmployeId);
        }
    }
}
