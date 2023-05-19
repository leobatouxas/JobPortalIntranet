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
    public class Experience
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public int EmployeId { get; set; }

        public Employe Employe { get; set; }

    }

    public class ExperienceFluent : EntityTypeConfiguration<Experience>
    {
        public ExperienceFluent()
        {
            ToTable("APP_EXPERIENCE");
            HasKey(cc => cc.Id);

            Property(cc => cc.Id).HasColumnName("EXP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(cc => cc.Title).HasColumnName("EXP_TITLE").IsRequired();
            Property(cc => cc.Date).HasColumnName("EXP_DATE");

            HasRequired(cc => cc.Employe).WithMany(c => c.Experiences).HasForeignKey(c => c.EmployeId);
        }
    }
}
