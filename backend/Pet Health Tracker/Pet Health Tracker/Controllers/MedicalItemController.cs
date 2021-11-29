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
        public ActionResult<MedicalItem> Post([FromBody] MedicalItem MedicalItem)
        {
            MedicalItem.TreatedOn = DateTime.Now;
            
            _db.MedicalItems.Add(MedicalItem);
            _db.SaveChanges();

           return MedicalItem;  // determined by what the front end wants to direct us to
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<MedicalItem>> Put(int id, [FromBody] MedicalItem MedicalItem)
        {
            if (MedicalItem.Id == id)
            {
                _db.MedicalItems.Update(MedicalItem);
                _db.SaveChanges();
            }

            return _db.MedicalItems.ToList();
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
