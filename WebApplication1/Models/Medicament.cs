using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Medicament
    {
        [Key]
        public int? IdMedicament { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]
        public string Type { get; set; }
        public ICollection<Prescrition_Medicament> all { get; set; }

    }
}
