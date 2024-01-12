using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static webapi.Common.Enums;

namespace webapi.Models.Entities
{
    public class AdoptionApplication
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ApplicationId { get; set; }
        public long ApplicantId { get; set; }
        public long PetId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public ApplicationStatus Status { get; set; }
        public string Comments { get; set; }
    }
}
