using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortalIntranetLibraryClass.modeleFluent
{
    public class Candidacy
    {
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
            HasKey(cc => new { cc.OfferId, cc.EmployeId });

            Property(cc => cc.OfferId).HasColumnName("CAN_OFFERID").IsRequired();
            Property(cc => cc.EmployeId).HasColumnName("CAN_EMPLOYEID").IsRequired();
            Property(cc => cc.Date).HasColumnName("CAN_DATE");
            Property(cc => cc.Status).HasColumnName("CAN_STATUS").IsRequired();

            HasRequired(cc => cc.Employe).WithMany(c => c.Candidacies).HasForeignKey(c => c.EmployeId);
            HasRequired(cc => cc.Offer).WithMany(c => c.Candidacies).HasForeignKey(c => c.OfferId);
        
            
        }
    }
}
