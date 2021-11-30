using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Health_Tracker.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }

        public string Clinic { get; set; }
        public string PrimaryVet { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual List<MedicalItem> MedicalItems { get; set; }

        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }

        public MedicalRecord()
        {

        }
    }
}
