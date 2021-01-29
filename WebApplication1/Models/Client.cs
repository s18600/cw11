using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Client : Person

    {
        public DateTime Birthdate { get; set; }

        public ICollection<Prescription> Prescriptions { get; set; }

    }
}
