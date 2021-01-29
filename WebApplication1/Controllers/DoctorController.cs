using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/medic")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        IDbService _service;

        public DoctorController(IDbService s)
        {
            _service = s;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Doctor str= _service.GetDoctor(3);
            if (str!= null)
                return Ok(str);
            return NotFound("NotFound");
        }

        [HttpGet("{ID}")]
        public IActionResult GetDoctor(int id)
        {

            Doctor str= _service.GetDoctor(id);
            if (str!= null)
                return Ok(str);
            return NotFound("Not found");

        }

        [HttpPost("{ID}")]
        public IActionResult RemoveDoctor(int id)
        {

            String str= _service.RemoveDoctor(id);
            if (str!= "Ok")
                return BadRequest(str);
            return Ok(str);

        }
        [HttpPost]
        public IActionResult AddDoctor(Doctor doctor)
        {

            String str= _service.AddDoctor(doctor);
            if (str != "Ok")
                return BadRequest(str);
            return Ok(str);

        }

    }
}