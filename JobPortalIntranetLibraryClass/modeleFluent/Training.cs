using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalIntranetLibraryClass.modeleFluent
{
    public class Training
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public int EmployeId { get; set; }

        public Employe Employe { get; set; }

    }

    public class TrainingFluent : EntityTypeConfiguration<Training>
    {
        public TrainingFluent()
        {
            ToTable("APP_TRAINING");
            HasKey(cc => cc.Id);

            Property(cc => cc.Id).HasColumnName("TRA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(cc => cc.Title).HasColumnName("TRA_TITLE").IsRequired();
            Property(cc => cc.Date).HasColumnName("TRA_DATE");

            HasRequired(cc => cc.Employe).WithMany(c => c.Trainings).HasForeignKey(c => c.EmployeId);
        }
    }
}
