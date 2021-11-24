using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Health_Tracker.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }
        public DateTime ApptDateTime { get; set; }
        public string EmailAddress { get; set; }
        public string Caregiver { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        public Appointment()
        {

        }
    }
}
