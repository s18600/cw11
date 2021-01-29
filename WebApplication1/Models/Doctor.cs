using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Doctor : Person
    {

        public string Email { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }

    }
}
