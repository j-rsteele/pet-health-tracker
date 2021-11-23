using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Health_Tracker.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual List<Weight> Weights { get; set; }

    }
}
