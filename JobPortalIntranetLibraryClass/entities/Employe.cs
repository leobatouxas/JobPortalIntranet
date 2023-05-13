using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalIntranetLibraryClass.entities
{
    internal class Employe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EMP_ID")]
        public int id;

        [Required]
        [Column("EMP_FIRSTNAME")]
        public string firstname;

        [Required]
        [Column("EMP_LASTNAME")]
        public string lastname;

        [Required]
        [Column("EMP_DATEOFBIRTH")]
        public DateTime dateofbirth;

        [Required]
        [Column("EMP_SENIORITY")]
        public int seniority;

        [Required]
        [Column("EMP_BIOGRAPHY")]
        public string biography;

        public ICollection<Candidacy> candidacys;
    }
}
