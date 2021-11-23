using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Health_Tracker.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public virtual List<MedicalItem> MedicalItems { get; set; }
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }

    }

    public class MedicalItem
    {
        public int Id { get; set; }
        public int MedicalRecordId { get; set; }
        public virtual MedicalRecord Record { get; set; }
        public MedicalRecordType RecordType { get; set;}
        public DateTime TreatedOn { get; set; }
        public string Description { get; set; }
    }


    public enum MedicalRecordType
    {
        Vaccination,
        Surgery,
        Treatments,
        Fixed,
        Allergies,
        Medications
    }
}
