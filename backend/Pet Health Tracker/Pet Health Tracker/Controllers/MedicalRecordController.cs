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
    public class MedicalRecordController : ControllerBase
    {

        private PetTrackerContext _db;

        public MedicalRecordController(PetTrackerContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<MedicalRecord>> Get()
        {
            return _db.MedicalRecords.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<MedicalRecord> Get(int id)
        {
            return _db.MedicalRecords.Find(id);
        }

        [HttpPost]
        public ActionResult<MedicalRecord> Post([FromBody] MedicalRecord MedicalRecord)
        {
            _db.MedicalRecords.Add(MedicalRecord);
            _db.SaveChanges();

            return MedicalRecord;
        }

        [HttpPut("{id}")]
        public ActionResult<Pet> Put(int id, [FromBody] MedicalRecord MedicalRecord)
        {
            if (MedicalRecord.Id == id)
            {
                _db.MedicalRecords.Update(MedicalRecord);
                _db.SaveChanges();
            }
            Pet toReturn = _db.Pets.Where(item => item.Id == MedicalRecord.PetId).FirstOrDefault();
            return toReturn;
        }

        [HttpDelete("{id}")]
        public ActionResult<List<MedicalRecord>> Delete(int id)
        {
            var MedicalRecord = _db.MedicalRecords.Find(id);
            _db.MedicalRecords.Remove(MedicalRecord);
            _db.SaveChanges();

            return _db.MedicalRecords.ToList();
        }
    }
}