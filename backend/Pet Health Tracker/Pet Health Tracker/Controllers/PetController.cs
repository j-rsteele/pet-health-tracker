using Microsoft.AspNetCore.Mvc;
using Pet_Health_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Health_Tracker
{
    [Route("api/[controller]")]
    [ApiController]

    public class PetController : ControllerBase
    {
        private PetTrackerContext _context;

        public PetController(PetTrackerContext context)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get()
        {
            return _context.Pets.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            Pet pet = _context.Pets.Find(id);
            return pet;
        }

        [HttpPost]
        public ActionResult<IEnumerable<Pet>> Post([FromBody] Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();

            return _context.Pets.ToList();
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Pet>> Delete(int id)
        {
            var pet = _context.Pets.Find(id);
            _context.Pets.Remove(pet);
            _context.SaveChanges();

            return _context.Pets.ToList();
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Pet>> Put(int id, [FromBody] Pet pet)
        {
            if (pet.Id == id)
            {
                _context.Pets.Update(pet);
                _context.SaveChanges();
            }

            return _context.Pets.ToList();
        }
    }
}
