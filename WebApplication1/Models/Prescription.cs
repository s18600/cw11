using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Prescription
    {
        [Key]
        public int? IdPrescrition { get; set; }
        [ForeignKey("Doctor")]
        public int? IdDoctor { get; set; }
      
        public Doctor Doctor { get; set; }
        [ForeignKey("Patient")]

        public int? IdClient { get; set; }
       
        public Client Client { get; set; }

        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime DueDate { get; set; }

        public ICollection<Prescrition_Medicament> all { get; set; }

    }
}
