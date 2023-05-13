using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalIntranetLibraryClass.entities
{
    internal class Offer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OFF_ID")]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        [Column("OFF_TITLE")]
        public string Title { get; set; }

        [StringLength(255)]
        [Required]
        [Column("OFF_TITLE")]
        public string Description { get; set; }

        [Required]
        [Column("OFF_DATE")]
        public DateTime Date { get; set; }

        [Required]
        [Column("OFF_SALARY")]
        public float Salary { get; set; }

        [Required]
        [Column("OFF_RESPONSIBLE")]
        public string Responsible { get; set; }

        [Required]
        [Column("STA_ID")]
        public Statut Statut { get; set; }

    }
}
