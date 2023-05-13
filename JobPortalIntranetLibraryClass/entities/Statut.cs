using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalIntranetLibraryClass.entities
{
    internal class Statut
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("STA_ID")]
        public int id;

        [Key]
        [Column("STA_LIBELLE")]
        public string libelle;

        public ICollection<Offer> offers { get; set; }
    }
}
