using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortalIntranetLibraryClass.modeleFluent
{
    public class Candidacy
    {
        public int id { get; set; }
        public int OfferId { get; set; }
        public Offer Offer { get; set; }

        public int EmployeId { get; set; }

        public Employe Employe { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Status { get; set; }
    }
    public class CandidacyFluent : EntityTypeConfiguration<Candidacy>
    {
        public CandidacyFluent()
        {
            ToTable("APP_CANDIDACY");
            HasKey(c => c.id);
            HasRequired(cc => cc.Employe).WithMany(c => c.Candidacies).HasForeignKey(c => c.EmployeId);
            HasRequired(cc => cc.Offer).WithMany(c => c.Candidacies).HasForeignKey(c => c.OfferId);
        
            Property(cc => cc.Date).HasColumnName("CAN_DATE");
            Property(cc => cc.Status).HasColumnName("CAN_STATUS").IsRequired();
        }
    }
}
