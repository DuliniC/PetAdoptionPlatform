using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Entities
{
    public class Location
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }
        public long? PetId { get; set; }
        public long? EventId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

    }
}
