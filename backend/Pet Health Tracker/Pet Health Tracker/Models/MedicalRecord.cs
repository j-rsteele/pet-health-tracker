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

        public MedicalRecord()
        {

        }
    }

    public class MedicalItem
    {
        public int Id { get; set; }
        public int MedicalRecordId { get; set; }
        public virtual MedicalRecord Record { get; set; }
        public MedicalItemType ItemType { get; set; }
        public DateTime TreatedOn { get; set; }
        public string Description { get; set; }

        public MedicalItem()
        {

        }
    }

    public enum MedicalItemType
    {
        Vaccination,
        Surgery,
        Treatments,
        Fixed,
        Allergies,
        Medications
    }
    
}
