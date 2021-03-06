using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pet_Health_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Health_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalItemController : ControllerBase
    {

        private PetTrackerContext _db;

        public MedicalItemController(PetTrackerContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<MedicalItem>> Get()
        {
            return _db.MedicalItems.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<MedicalItem> Get(int id)
        {
            return _db.MedicalItems.Find(id);
        }

        [HttpPost]
        public ActionResult<Pet> Post([FromBody] MedicalItem MedicalItem)
        {
            
            _db.MedicalItems.Add(MedicalItem);
            _db.SaveChanges();

            var medRecord = _db.MedicalRecords.Find(MedicalItem.MedicalRecordId);
            return _db.Pets.Find(medRecord.Id);  // determined by what the front end wants to direct us to
        }

        [HttpPut("{id}")]
        public ActionResult<Pet> Put(int id, [FromBody] MedicalItem MedicalItem)
        {
            if (MedicalItem.Id == id)
            {
                _db.MedicalItems.Update(MedicalItem);
                _db.SaveChanges();
            }
            var medRecord = _db.MedicalRecords.Find(MedicalItem.MedicalRecordId);
            return _db.Pets.Find(medRecord.Id);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<MedicalItem>> Delete(int id)
        {
            var MedicalItem = _db.MedicalItems.Find(id);
            _db.MedicalItems.Remove(MedicalItem);
            _db.SaveChanges();

            return _db.MedicalItems.ToList();
        }
     }
}
