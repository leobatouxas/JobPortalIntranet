using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace JobPortalIntranetLibraryClass.modeleFluent
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public float Salary { get; set; }

        [Required]
        public string Responsible { get; set; }

        public ICollection<Candidacy> Candidacies { get; set; }

        public int StatutId { get; set; }

        public Statut Statut { get; set; }

    }
    public class OfferFluent : EntityTypeConfiguration<Offer>
    {
        public OfferFluent()
        {
            ToTable("APP_OFFER");
            HasKey(cc => cc.Id);

            Property(cc => cc.Id).HasColumnName("OFF_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(cc => cc.Title).HasColumnName("OFF_TITLE").IsRequired();
            Property(cc => cc.Description).HasColumnName("OFF_DESCRIPTION").IsRequired();
            Property(cc => cc.Date).HasColumnName("OFF_DATE");
            Property(cc => cc.Salary).HasColumnName("OFF_SALARY");
            Property(cc => cc.Responsible).HasColumnName("OFF_RESPONSIBLE").IsRequired();

            HasMany(cc => cc.Candidacies).WithRequired(c => c.Offer).HasForeignKey(c => c.OfferId);
            HasRequired(cc => cc.Statut).WithMany(c => c.Offers).HasForeignKey(c => c.StatutId);
                        
        }
    }
}
