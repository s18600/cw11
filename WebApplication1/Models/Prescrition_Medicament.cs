using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Prescrition_Medicament
    {

        public int? id { get; set; }

        [ForeignKey("Medicament")]
        public int? IdMedicament { get; set; }
        [ForeignKey("Prescription")]
        public int? IdPrescrtiption { get; set; }

        public Medicament Medicament { get; set; }
        public Prescription Prescription { get; set; }

        public int Dose { get; set; }
        [Required]
        public String Details { get; set; }

    }
}
