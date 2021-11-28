using Microsoft.AspNetCore.Mvc;
using 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pet_Health_Tracker.Models;

namespace Pet_Health_Tracker
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRecordController : ControllerBase
    {
        private PetTrackerContext _db;

        public MedicalRecordController(PetTrackerContext db)
        {
            _db = db;
        }

        // GET api/<MedicalRecordItemController>/5
        [HttpGet("{Id}")]
        public ActionResult <int> Get()
        {
            return new string [] {Pet.Name, MedicalItem, MedicalItemType, 
        }

        // POST api/<MedicalRecordController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MedicalRecordController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MedicalRecordController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
