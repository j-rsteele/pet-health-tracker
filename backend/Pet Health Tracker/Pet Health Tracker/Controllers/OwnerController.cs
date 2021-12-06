using Microsoft.AspNetCore.Mvc;
using Pet_Health_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;

namespace Pet_Health_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class OwnerController : ControllerBase
    {

        private PetTrackerContext _context;

        public OwnerController(PetTrackerContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Owner>> Get()
        {
            return _context.Owners.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Owner> Get(int id)
        {
            Owner owner = _context.Owners.Find(id);
            return owner;
        }

        [HttpPost]
        public ActionResult<IEnumerable<Owner>> Post([FromBody] Owner owner)
        {
            //var ownerTable = _context.Owners;
            //ownerTable.Add(owner);
            _context.Owners.Add(owner);
            _context.SaveChanges();

            return _context.Owners.ToList();
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Owner>> Delete(int id)
        {
            var owner = _context.Owners.Find(id);
            _context.Owners.Remove(owner);
            _context.SaveChanges();

            return _context.Owners.ToList();
        }

        [HttpPut("{id}")]
        public ActionResult<Owner> Put(int id, [FromBody] Owner owner)
        {
            if (owner.Id == id)
            {
                _context.Owners.Update(owner);
                _context.SaveChanges();
            }

            return _context.Owners.Find(id);
        }
    }
}