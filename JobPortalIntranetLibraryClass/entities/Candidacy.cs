using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalIntranetLibraryClass.entities
{
    internal class Candidacy
    {
        [Required]
        [Column("OFF_ID")]
        public Offer offer { get; set; }

        [Required]
        [Column("EMP_ID")]
        public Employe employe { get; set; }

        [Required]
        [Column("CAN_DATE")]
        public DateTime date { get; set; }

        [Required]
        [Column("CAN_STATUS")]
        public string status { get; set; }
    }
}
