using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace JobPortalIntranetLibraryClass.modeleFluent
{
    public class Statut
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Libelle { get; set; }

        public ICollection<Offer> Offers { get; set; }
    }

    public class StatutFluent : EntityTypeConfiguration<Statut>
    {
        public StatutFluent()
        {
            ToTable("APP_STATUT");
            HasKey(cc => cc.Id);
            Property(cc => cc.Id).HasColumnName("STA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(cc => cc.Libelle).HasColumnName("STA_LIBELLE").IsRequired();
            HasMany(cc => cc.Offers).WithRequired(c => c.Statut).HasForeignKey(c => c.StatutId);
        }
    }
}
