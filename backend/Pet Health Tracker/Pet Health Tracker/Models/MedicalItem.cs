using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Pet_Health_Tracker.Models
{
    public class MedicalItem
    {
        public int Id { get; set; }
        public int MedicalRecordId { get; set; }
        public virtual MedicalRecord MedicalRecord { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MedicalItemType ItemType { get; set;}
        public DateTime TreatedOn { get; set; }
        public string Description { get; set; }
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
