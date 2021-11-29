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
    public class AppointmentController : ControllerBase
    {
       
        private PetTrackerContext _context;

        public AppointmentController(PetTrackerContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Appointment>> Get()
        {
            return _context.Appointments.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Appointment> Get(int id)
        {
            Appointment appointment = _context.Appointments.Find(id);
            return appointment;
        }

        [HttpPost]
        public ActionResult<IEnumerable<Appointment>> Post([FromBody] Appointment appointment)
        {
            //var ownerTable = _context.Owners;
            //ownerTable.Add(owner);
            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            return _context.Appointments.ToList();
        }


    }
}
