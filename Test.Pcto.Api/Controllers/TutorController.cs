using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Test.Pcto.Api.Data;
using Test.Pcto.Api.Models;
using System.Security.Cryptography.Xml;

namespace Test.Pcto.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TutorController : ControllerBase
    {
        private readonly ILogger<TutorController> _logger;
        private readonly SchoolDbContext _ctx;

        public TutorController(ILogger<TutorController> logger, SchoolDbContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            #region OLD
            //List<Tutor> tutors = new List<Tutor>()
            //{
            //    new Tutor() { TutorId = 1, Name = "Gennaro" },
            //    new Tutor() { TutorId = 2, Name = "Fabio" },
            //    new Tutor() { TutorId = 3, Name = "Giacobbe" },
            //    new Tutor() { TutorId = 4, Name = "Luca" },
            //    new Tutor() { TutorId = 5, Name = "Sandro" },
            //    new Tutor() { TutorId = 6, Name = "Annamaria" },
            //    new Tutor() { TutorId = 7, Name = "Susanna" }
            //};
            ////try
            ////{
            ////    throw new Exception("MIIIIIIIIIIIINCHIA!");
            ////}
            ////catch (Exception ex)
            ////{
            ////    return StatusCode(500);
            ////}
            //return Ok(tutors);
            #endregion

            List<Tutor> tutors = _ctx.Tutors.ToList();
            return Ok(tutors);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TutorModel tutor)
        {
            Tutor t = new Tutor()
            {
                Name = tutor.Name,
            };
            _ctx.Tutors.Add(t);
            _ctx.SaveChanges();
            return Ok(t);
        }
    }
}
