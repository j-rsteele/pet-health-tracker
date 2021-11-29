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
    public class WeightController : ControllerBase
    {

        private PetTrackerContext _db;

        public WeightController(PetTrackerContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Weight>> Get()
        {
            return _db.Weights.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Weight> Get(int id)
        {
            return _db.Weights.Find(id);
        }

        [HttpPost]
        public ActionResult<Weight> Post([FromBody] Weight Weight)
        {
            _db.Weights.Add(Weight);
            _db.SaveChanges();

            Weight.Pet = _db.Pets.Find(Weight.PetId);

            return Weight;
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Weight>> Put(int id, [FromBody] Weight Weight)
        {
            if (Weight.Id == id)
            {
                _db.Weights.Update(Weight);
                _db.SaveChanges();
            }

            return _db.Weights.ToList();
        }

        [HttpDelete("{id}")]
        public ActionResult<List<Weight>> Delete(int id)
        {
            var Weight = _db.Weights.Find(id);
            _db.Weights.Remove(Weight);
            _db.SaveChanges();

            return _db.Weights.ToList();
        }
    }
}