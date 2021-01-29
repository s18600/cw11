using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
   public interface IDbService
    {

        string AddDoctor(Doctor doctor);

        Doctor GetDoctor(int id);

        string UpdateDoctor(Doctor doctor);

        string RemoveDoctor(int id);

    }
}
