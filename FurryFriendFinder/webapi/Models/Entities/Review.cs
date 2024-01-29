using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Entities
{
    public class Review
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ReviewId { get; set; }
        public long ApplicantId { get; set; }
        public long PetId { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
