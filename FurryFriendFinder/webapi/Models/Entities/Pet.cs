using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static webapi.Common.Enums;

namespace webapi.Models.Entities
{
    public class Pet
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long PetName { get; set; }
        public PetType PetType { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public string HealthRecords { get; set; }
        public bool PetStatus { get; set; }
        public long PetOwnerId { get; set; }
        public virtual User PetOwner { get; set; }
        public virtual Location Location { get; set; }
    }
}
