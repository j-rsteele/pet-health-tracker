using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Health_Tracker.Models
{
    public class Weight
    {
        public int Id { get; set; }
        public int CurrentWeight { get; set; }
        public DateTime Date { get; set; }
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }

        public Weight()
        {

        }
    }
}
